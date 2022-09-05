using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Invalid Username")]
        [StringLength(20, MinimumLength = 3)]
        public string UserName { get; set; }

        [Required] public string KnownAs{get;set;}
        [Required] public string Gender{get;set;}
        [Required] public DateTime DateOfBirth{get;set;}
        [Required] public string City{get;set;}
        [Required] public string Country{get;set;}
        

        [Required(AllowEmptyStrings = false, ErrorMessage = "Invalid Password")]
        [StringLength(20, MinimumLength = 3)]
        public string Password { get; set; }
    }
}