using System.ComponentModel.DataAnnotations;

namespace AspNetTest.Models
{
    public class RegistrationRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}