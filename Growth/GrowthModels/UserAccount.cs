using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace GrowthModels
{
    public class UserAccount
    {
        [Key]
        [Required]
        [BindRequired]
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
        [BindRequired]
        public string Password { get; set; }
        [Required]
        [BindRequired]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; } // ? makes this field nullable
    }
}