using System;
using System.ComponentModel.DataAnnotations;

namespace weddingPlanner
{
    public class LoginUser
    {
        [Key]
        [Required]
        public string LoginEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}