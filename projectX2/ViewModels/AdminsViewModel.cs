using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projectX2.Models
{
    public class AdminsViewModel
    {
        public Int32 Id { get; set; }
        public Int32 RolesId { get; set; }

        [Required]
        [DataType("Password")]
        public string Password { get; set; }

        [DataType("Password")]
        [DisplayName("Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [DataType("Name")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "The Email Address is not valid")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [Display(Name = "Email:")]
        public string Email { get; set; }



    }
}
