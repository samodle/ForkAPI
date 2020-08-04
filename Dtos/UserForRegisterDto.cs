using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForkApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "You must specify username between 3 and 30 characters. ")]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage ="You must specify password between 4 and 8 characters.")]
        public string Password { get; set; }

    }
}
