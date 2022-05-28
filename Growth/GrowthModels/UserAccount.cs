using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GrowthModels
{
    public class UserAccount
    {
        [Key]
        [Required]
        [BindRequired]
        public string Username { get; set; }
        [Required]
        [BindRequired]
        public string Password { get; set; }
        [Required]
        [BindRequired]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; } // ? makes this field nullable
    }
}