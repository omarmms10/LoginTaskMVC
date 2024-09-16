using Day6Demo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Day6Demo.Models
{
    public partial class User
    {
        [Key]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The username is required.")]
        [MaxLength(50, ErrorMessage = "The username cannot exceed 50 characters.")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The password is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "The password must be between 8 and 100 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,100}$",
            ErrorMessage = "The password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        [Display(Name = "Password")]
        public string Password { get; set; }


    }
}
