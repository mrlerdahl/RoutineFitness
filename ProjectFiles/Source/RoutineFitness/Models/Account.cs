using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RoutineFitness.Models
{
    public class Account
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username required")]
        [StringLength(30)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [StringLength(40)]
        public string Password { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }
    }
}
