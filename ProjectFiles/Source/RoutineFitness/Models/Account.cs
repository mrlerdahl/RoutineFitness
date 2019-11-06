//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNetCore.Identity;

//namespace RoutineFitness.Models
//{
//    public class Account 
//    {
//        [Key]
//        public int UserId { get; set; }

//        [Required(ErrorMessage = "Username required")]
//        [StringLength(30)]
//        public string UserName { get; set; }

//        [Required(ErrorMessage = "Password required")]
//        [StringLength(40)]
//        public string Password { get; set; }

//        [Required(ErrorMessage = "Email required")]
//        [DataType(DataType.EmailAddress)]
//        [EmailAddress]
//        public string Email { get; set; }

//        [StringLength(30)]
//        public string FirstName { get; set; }

//        [StringLength(30)]
//        public string LastName { get; set; }

//        public ICollection<Workout> Workouts { get; set; }
//    }
//}
