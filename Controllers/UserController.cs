using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

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

        public UserController(UsersDbContext dbContext)
        {
            _dbContext = dbContext;
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