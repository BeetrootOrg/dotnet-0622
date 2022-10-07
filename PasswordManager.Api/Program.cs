using MediatR;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using PasswordManager.Api.Configuration;
using PasswordManager.Domain;
using PasswordManager.Domain.Commands;
using PasswordManager.Domain.Database;

using Serilog;

using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseSerilog((ctx, lc) => 
{
    lc.ReadFrom.Configuration(builder.Configuration);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
{
    options.SwaggerDoc("v1", new OpenApiInfo 
    {
        Title = "PasswordManager", 
        Version = "v1" , 
        Description = "An ASP.NET Core Web API for managing user passwords"
    });
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddAuthorization();

builder.Services.AddHealthChecks().AddNpgSql(sp => 
{
    var configuration = sp.GetRequiredService<IOptionsMonitor<AppConfiguration>>();
    return configuration.CurrentValue.ConnectionString;
}, timeout: TimeSpan.FromSeconds(2));

builder.Services.Configure<AppConfiguration>(builder.Configuration);

builder.Services.AddDomainServices((sp, options) => 
{
    var configuration = sp.GetRequiredService<IOptionsMonitor<AppConfiguration>>();
    var loggerFactory = sp.GetRequiredService<ILoggerFactory>();
    options.UseNpgsql(configuration.CurrentValue.ConnectionString).UseLoggerFactory(loggerFactory);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks("/health");

app.Run();

public partial class Program { }