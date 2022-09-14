using System;
using AspNetTest.Database;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<UsersDbContext>((options) =>
{
	options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=users;");
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = new PathString("/login.html");
		options.LogoutPath = new PathString("/sign-out");
		options.Cookie.Name = "TestSignIn";
		options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
		options.SlidingExpiration = true;
	});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseFileServer();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
