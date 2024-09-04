using System.ComponentModel.DataAnnotations;

namespace DTOs.User
{
    public class RegisterUserDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "First name must contain at least 2 characters")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Last name must contain at least 2 characters")]
        public string LastName { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Username must contain at least 4 characters!")]
        public string Username { get; set; }
        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$", ErrorMessage = "Password must contain at least 8 characters\n including a number and a special character!")]
        public string Password { get; set; }
    }
}
