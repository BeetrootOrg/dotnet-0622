using AspNetTest.Models;

using Microsoft.EntityFrameworkCore;

namespace AspNetTest.Database
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; init; }

        public UsersDbContext() : base()
        {
        }

        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
        }
    }
}