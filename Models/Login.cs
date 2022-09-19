using System.ComponentModel.DataAnnotations;

namespace AspNetTest.Models
{
    public class LoginRequest
    {
        [Required]
        public string Username { get; init; }

        [Required]
        public string Password { get; init; }

        [Required]
        public string Code { get; init; }
    }
}