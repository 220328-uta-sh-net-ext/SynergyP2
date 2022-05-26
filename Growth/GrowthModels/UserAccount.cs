using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace GrowthModels
{
    public class UserAccount
    {
        [Key]
        [Required]
        [RegularExpression("[a-zA-Z")]
        public string Username
        {
            get { return Username; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                    Username = value;
                else
                    throw new ValidationException("Your name can only contain letters");
            }
        }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; } // ? makes this field nullable
    }
}