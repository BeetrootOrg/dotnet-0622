using System.IO;

using Microsoft.EntityFrameworkCore;

using Wishlist.Domain.Database;

namespace Wishlist.UnitTests.Helpers;

internal static class DbContextHelper
{
    public static WishlistDbContext CreateTestDb()
    {
        var tempFile = Path.GetTempFileName();
        return CreateTestDb($"Data Source={tempFile};");
    }

    public static WishlistDbContext CreateTestDb(string connectionString)
    {
        var options = new DbContextOptionsBuilder<WishlistDbContext>()
            .UseSqlite(connectionString)
            .Options;

        var dbContext = new WishlistDbContext(options);
        dbContext.Database.Migrate();

        return dbContext;
    }
}