using SpaDay.Models;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required, must be between 5 and 15 characters long.")]
        [StringLength(15, MinimumLength = 5)]
        public string UserName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "The password is between 6 and 20 characters.")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Doesn't match")]
        [StringLength (20, MinimumLength = 6)]

        public string VerifyPassword { get; set; }

    }
}
