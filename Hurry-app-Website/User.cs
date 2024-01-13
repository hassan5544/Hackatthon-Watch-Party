using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Hurry_app_Website
{
    public class User : IdentityUser
    {

        [Required(ErrorMessage = "User name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = "Email is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the email is 120 characters.")]
        public string PassWord { get; set; } = "";

    }
}
