using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserRoleAdmin.Models
{
    public class AppUser : IdentityUser
    {

    }

    public class CreateUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
    
    public class LoginModel
    {
        [Required, UIHint("email")]
        public string Email { get; set; }

        [Required, UIHint("password")]
        public string Password { get; set; }
    }
}
