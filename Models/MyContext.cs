using Microsoft.EntityFrameworkCore;

namespace weddingPlanner.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter alongcopy
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Wedding> weddings {get;set;}
        public DbSet<RSVP> RSVPs {get;set;}
    }
}