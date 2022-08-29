using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using Persons.Web.Configuration;
using Persons.Web.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<AppConfiguration>(builder.Configuration);
builder.Services.AddDbContext<PersonsContext>((sp, options) =>
{
    var configuration = sp.GetRequiredService<IOptionsMonitor<AppConfiguration>>();
    var connectionString = configuration?.CurrentValue?.ConnectionString
        ?? throw new ArgumentException(nameof(configuration));
    options.UseNpgsql(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Persons}/{action=Index}/{id?}");

app.Run();
