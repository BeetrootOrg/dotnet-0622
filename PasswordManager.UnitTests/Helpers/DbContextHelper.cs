using Microsoft.EntityFrameworkCore;

using PasswordManager.Domain.Database;

namespace PasswordManager.UnitTests.Helpers;

internal static class DbContextHelper
{
    public static PasswordManagerDbContext CreateDbContext()
    {
        var tempFile = Path.GetTempFileName();
        var options = new DbContextOptionsBuilder<PasswordManagerDbContext>().UseSqlite($"Data Source={tempFile};").Options;

        var dbContext = new PasswordManagerDbContext(options);
        dbContext.Database.Migrate();
        return dbContext;
    }
}