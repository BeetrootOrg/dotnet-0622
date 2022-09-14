using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using AspNetTest.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetTest.Controllers;

public class UserController : ControllerBase
{
	[HttpPost("sign-in")]
	public async Task<IActionResult> SignIn([FromBody] LoginRequest request,
		[FromQuery] string returnUrl = null,
		CancellationToken token = default)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}

		var username = request.Username;
		var password = request.Password;
		if (username == "admin" && password == "123456")
		{
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

			return Ok(new
			{
				Location = returnUrl ?? "/"
			});
		}

		return BadRequest(new
		{
			Message = "wrong username or password"
		});
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