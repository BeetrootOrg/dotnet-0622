using Microsoft.EntityFrameworkCore;

using Wishlist.Contracts.Database;

using WishlistModel = Wishlist.Contracts.Database.Wishlist;

namespace Wishlist.Domain.Database;

public class WishlistDbContext : DbContext
{
    public DbSet<Present> Presents { get; init; }
    public DbSet<WishlistModel> Wishlists { get; init; }

    public WishlistDbContext() : base()
    {
    }

    public WishlistDbContext(DbContextOptions<WishlistDbContext> options) : base(options)
    {
    }
}