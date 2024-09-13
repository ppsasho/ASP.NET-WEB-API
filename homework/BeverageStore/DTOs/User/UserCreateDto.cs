using System.ComponentModel.DataAnnotations;

namespace DTOs.User
{
    public  class UserCreateDto
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Can't have a first name longer than 50 characters!")]
        [MinLength(2, ErrorMessage = "First name must contain at least 2 characters")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Can't have a last name longer than 50 characters!")]
        [MinLength(2, ErrorMessage = "Last name must contain at least 2 characters")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[!@#$%^&*()_+=\[{\]};:<>|./?,-]).{8,}$", 
            ErrorMessage = "Password must contain at least 8 characters\n including a number and a special character!")]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
