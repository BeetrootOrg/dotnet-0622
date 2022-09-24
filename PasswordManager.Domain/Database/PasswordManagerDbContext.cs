using Microsoft.EntityFrameworkCore;

using PasswordManager.Contracts.Database;

namespace PasswordManager.Domain.Database;

public class PasswordManagerDbContext : DbContext
{

    public DbSet<User> Users { get; set; }
    public DbSet<Password> Passwords { get; set; }
    public PasswordManagerDbContext() : base()
    {
    }
    public PasswordManagerDbContext(DbContextOptions<PasswordManagerDbContext> options) : base(options)
    {
    }
}