using Microsoft.EntityFrameworkCore;
using ConsoleApp.Models;

namespace ConsoleApp.Contexts;

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors {get;init;}
    public DbSet<Book> Books {get;init;}
    public DbSet<Customer> Customers {get;init;}
    public DbSet<BorrowingHistory> BorrowingHistory {get;init;}
    public LibraryContext() : base()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=postgres;Password=fyfnjksq123;Host=localhost;Port=5432;Database=tbl_library;")
			.LogTo(System.Console.WriteLine)
			;
    }
}