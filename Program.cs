using System;
using System.Net.Http;

using AspNetTest.Clients;
using AspNetTest.Database;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<UsersDbContext>((options) => _ = options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=users;"));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = new PathString("/login.html");
        options.LogoutPath = new PathString("/sign-out");
        options.Cookie.Name = "TestSignIn";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
        options.SlidingExpiration = true;
    });

builder.Services.Configure<CookieAuthenticationOptions>(CookieAuthenticationDefaults.AuthenticationScheme, options =>
{
    options.Events.OnRedirectToAccessDenied = context =>
    {
        context.Response.StatusCode = StatusCodes.Status403Forbidden;
        return context.Response.CompleteAsync();
    };

    options.Events.OnRedirectToLogin = context =>
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        return context.Response.CompleteAsync();
    };
});

builder.Services.AddSingleton(_ => new GoogleAuthClient(new HttpClient
{
    BaseAddress = new Uri("https://www.authenticatorApi.com")
}, "AspNetTest", "vh4t2uygryu4rtiuewgufvicyis6d"));

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.

app.UseFileServer();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
