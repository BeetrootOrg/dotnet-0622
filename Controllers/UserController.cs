using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

using AspNetTest.Clients;
using AspNetTest.Database;
using AspNetTest.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetTest.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UsersDbContext _dbContext;
        private readonly GoogleAuthClient _googleAuthClient;

        public UserController(UsersDbContext dbContext, GoogleAuthClient googleAuthClient)
        {
            _dbContext = dbContext;
            _googleAuthClient = googleAuthClient;
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn([FromBody] LoginRequest request,
            CancellationToken token = default)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string username = request.Username;
            string password = request.Password;

            User user = await _dbContext.Users.SingleOrDefaultAsync(user => user.Username == username && user.Password == password,
                token);

            if (user == null)
            {
                return BadRequest(new
                {
                    Message = "wrong username or password"
                });
            }

            bool isValid = await _googleAuthClient.IsValid(request.Code, token);
            if (!isValid)
            {
                return BadRequest(new
                {
                    Message = "invalid code"
                });
            }

            Claim[] claims = new[]
            {
                new Claim(ClaimTypes.Name, request.Username),
            };

            ClaimsIdentity claimsIdentity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new(claimsIdentity);
            AuthenticationProperties authProperties = new();

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                claimsPrincipal,
                authProperties);

            return Ok();
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request,
            CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string username = request.Username;
            string password = request.Password;

            bool userExists = await _dbContext.Users.AnyAsync(x => x.Username == username, cancellationToken);
            if (userExists)
            {
                return BadRequest(new
                {
                    Message = "user already exist"
                });
            }

            _ = await _dbContext.Users.AddAsync(new User
            {
                Username = username,
                Password = password
            }, cancellationToken);

            _ = await _dbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }

        [HttpGet("sign-out")]
        public new async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }

        [HttpGet("me")]
        [Authorize]
        public IActionResult Me()
        {
            return Ok(new
            {
                Username = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value
            });
        }
    }
}