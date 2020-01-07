using System;
using System.ComponentModel.DataAnnotations;

namespace Usersignup2.ViewModels
{
    public class AddUserViewModel
    {   //this is a POCO -  plain old c# object. we keep saying it, so imma write that down

        [Required]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]

        public string Verify { get; set; }


        public AddUserViewModel()
        {

        }
    }
}
