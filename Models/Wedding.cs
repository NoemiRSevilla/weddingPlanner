using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace weddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}
        [Required]
        public string WOne {get;set;}
        [Required]
        public string WTwo {get;set;}
        [Required]
        [FutureDate]
        public DateTime When {get;set;}
        public string Address {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
        public User Creator {get;set;}
        public int UserId {get;set;}
        public List<RSVP> RSVPs {get;set;}
    }
} 