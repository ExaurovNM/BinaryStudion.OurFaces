using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BinaryStudio.OurFaces.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Hey, enter a UserName!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "UserName length must be between 3 and 20")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "No password? Huh...")]
        [StringLength(20, MinimumLength = 6,  ErrorMessage = "Password length must be between 6 and 20")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Forgot?")]
        [Compare("Password",ErrorMessage = "Passwords dont match!")]
        public string ConfirmPassword { get; set; }
    }
}