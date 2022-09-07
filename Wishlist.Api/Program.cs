using System;

using MediatR;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using Wishlist.Api.Configuration;
using Wishlist.Domain.Commands;
using Wishlist.Domain.Database;
using Wishlist.Domain.Helpers;
using Wishlist.Domain.Helpers.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks()
    .AddNpgSql((sp) =>
    {
        var configuration = sp.GetRequiredService<IOptionsMonitor<AppConfiguration>>();
        return configuration.CurrentValue.ConnectionString;
    },
        timeout: TimeSpan.FromSeconds(2));

builder.Services.Configure<AppConfiguration>(builder.Configuration);

builder.Services.AddMediatR(typeof(CreateWishlistCommand));
builder.Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
builder.Services.AddDbContext<WishlistDbContext>((sp, options) =>
{
    var configuration = sp.GetRequiredService<IOptionsMonitor<AppConfiguration>>();
    options.UseNpgsql(configuration.CurrentValue.ConnectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.MapHealthChecks("/health");

app.Run();
