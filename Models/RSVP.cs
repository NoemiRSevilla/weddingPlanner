using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace weddingPlanner.Models
{
    public class RSVP
    {
        [Key]
        public int RSVPId {get;set;}
        public int WeddingId {get;set;}
        public int UserId {get;set;}
        public Wedding Weddings {get;set;}
        public User Guest {get;set;}
    }
}