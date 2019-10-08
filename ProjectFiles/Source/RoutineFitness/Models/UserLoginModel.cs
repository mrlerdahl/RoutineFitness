using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RoutineFitness.Models
{
    public class UserLoginModel
    {
        [Required]
        [UIHint("username")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
