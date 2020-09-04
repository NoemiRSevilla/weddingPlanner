using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using weddingPlanner.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using weddingPlanner;

// Other using statements
namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string UserInSession = HttpContext.Session.GetString("Email");
            if (UserInSession != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
        }

        [HttpPost("submit")]
        public IActionResult Submit(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    // You may consider returning to the View at this point
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetString("Email", newUser.Email);
                    return Redirect($"/dashboard");
                }
            }
            else
            {
                TempData["First Name"] = newUser.FirstName;
                TempData["Last Name"] = newUser.LastName;
                TempData["Email"] = newUser.Email;
                return View("Index");
            }
        }

        [HttpPost("submitlogin")]
        public IActionResult submitlogin(LoginUser retrievedUser)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.users.FirstOrDefault(u => u.Email == retrievedUser.LoginEmail);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "You could not be logged in");
                    return View("Index");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();

                // verify provided password against hash stored in dbcopy
                var result = hasher.VerifyHashedPassword(retrievedUser, userInDb.Password, retrievedUser.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "You could not be logged in");
                    return View("Index");
                }
                HttpContext.Session.SetString("Email", retrievedUser.LoginEmail);
                return Redirect("/dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            string UserInSession = HttpContext.Session.GetString("Email");
            if (UserInSession != null)
            {
                User retrievedUser = dbContext.users.FirstOrDefault(u => u.Email == UserInSession);

                List<Wedding> AllWeddings = dbContext.weddings
                .Include(r => r.RSVPs)
                .ThenInclude(g => g.Guest)
                .ToList();

                ViewBag.current = retrievedUser;
                return View(AllWeddings);
            }
            else
            {
                return RedirectToAction("Logout");
            }
        }

        [HttpPost("wedding/submit")]
        public IActionResult WeddingSubmit(Wedding newWedding)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newWedding);
                dbContext.SaveChanges();
                return Redirect($"/wedding/{newWedding.WeddingId}");
            }
            else
            {
                string UserInSession = HttpContext.Session.GetString("Email");
                User retrievedUser = dbContext.users.FirstOrDefault(c => c.Email == UserInSession);
                
                TempData["WOne"] = newWedding.WOne;
                TempData["WTWo"] = newWedding.WTwo;
                TempData["When"] = newWedding.When;
                TempData["Address"] = newWedding.Address;
                ViewBag.creator = retrievedUser;

                return View("NewWeddingForm");
            }
        }

        [HttpGet("newweddingform")]
        public IActionResult NewWeddingForm()
        {
            string UserInSession = HttpContext.Session.GetString("Email");

            User retrievedUser = dbContext.users.FirstOrDefault(c => c.Email == UserInSession);
            Console.WriteLine(UserInSession);

            ViewBag.creator = retrievedUser;

            return View();
        }

        [HttpGet("wedding/{WeddingId}")]
        public IActionResult ShowWeddingInfo(int WeddingId)
        {
            Wedding WeddingInfo = dbContext.weddings
            .Include(a => a.RSVPs)
            .ThenInclude(g => g.Guest)
            .FirstOrDefault(u => u.WeddingId == WeddingId);

            ViewBag.W = WeddingInfo;
            return View();
        }

        [HttpGet("delete")]
        public IActionResult DeleteWedding(int WeddingId)
        {
            Wedding WeddingInfo = dbContext.weddings.FirstOrDefault(u => u.WeddingId == WeddingId);
            dbContext.weddings.Remove(WeddingInfo);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/{WeddingId}/add/{UserId}")]
        public IActionResult GuestRSVP(Wedding theWedding, int WeddingId, int UserId)
        {
            RSVP newRSVP = new RSVP();
            newRSVP.UserId = UserId;
            newRSVP.WeddingId = WeddingId;
            dbContext.RSVPs.Add(newRSVP);
            dbContext.SaveChanges();

            return Redirect($"/wedding/{theWedding.WeddingId}");
        }

        [HttpGet("guest/{WeddingId}/remove/{UserId}")]
        public IActionResult unRSVP(Wedding theWedding, int WeddingId, int UserId)
        {
            RSVP unRSVP = dbContext.RSVPs
            .FirstOrDefault(u => u.UserId == UserId && u.WeddingId == WeddingId);

            dbContext.RSVPs.Remove(unRSVP);
            dbContext.SaveChanges();
            return Redirect($"/wedding/{WeddingId}");
        }
    }
}