using System;
using AspNetTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetTest.Controllers
{
	public class PostController : ControllerBase
	{
		[HttpGet("/api/posts")]
		public IActionResult GetAll()
		{
			return Ok(new[]
			{
				new Post
				{
					Caption = "test caption",
					Description = "test description",
					ImageUrl = new Uri("/images/image1.gif", UriKind.Relative)
				}
			});
		}
	}
}