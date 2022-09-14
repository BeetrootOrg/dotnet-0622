using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetTest.Controllers;

public class UserController : ControllerBase
{
	[HttpPost("sign-in")]
	public Task<IActionResult> SignIn(CancellationToken token)
	{
		return Task.FromResult<IActionResult>(Ok());
	}

	[HttpPost("sign-out")]
	public Task<IActionResult> SignOut(CancellationToken token)
	{
		return Task.FromResult<IActionResult>(Ok());
	}
}