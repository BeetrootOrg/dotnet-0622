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

namespace AspNetTest.Controllers;

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

		var username = request.Username;
		var password = request.Password;

		var user = await _dbContext.Users.SingleOrDefaultAsync(user => user.Username == username && user.Password == user.Password);

		if (user == null)
		{
			return BadRequest(new
			{
				Message = "wrong username or password"
			});
		}

		var claims = new[]
		{
			new Claim(ClaimTypes.Name, request.Username),
		};

		var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
		var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
		var authProperties = new AuthenticationProperties();

		await HttpContext.SignInAsync(
			CookieAuthenticationDefaults.AuthenticationScheme,
			claimsPrincipal,
			authProperties);

		return Ok();
	}

	[HttpGet("sign-out")]
	public async Task<IActionResult> SignOut(CancellationToken token)
	{
		await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
		return Redirect("/");
	}

	[HttpGet("me")]
	[Authorize]
	public IActionResult Me(CancellationToken token)
	{
		return Ok(new
		{
			Username = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value
		});
	}
}