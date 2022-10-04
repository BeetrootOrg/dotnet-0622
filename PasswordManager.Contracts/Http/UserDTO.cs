using System.ComponentModel.DataAnnotations;

namespace PasswordManager.Contracts.Http;

public class UserDTO
{
    [Required]
    [MaxLength(100)]
    public string UserName { get; set; }
    [Required]
    [MaxLength(150)]
    public string Email { get; set; }
    [Required]
    [MaxLength(512)]
    public string Password { get; set; }
}

public class UserDTOResponse
{
    public string UserName { get; set; }
    public string Email { get; set; }
}
