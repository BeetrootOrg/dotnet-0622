using System;
using EfExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExample.Contexts;
public class LibraryContext : DbContext
{
    public DbSet <Author> Authors { get; init; }
    public DbSet <Book> Books { get; init; }
    public DbSet<Customer> Customers { get; init; }
    public DbSet<Journal> Journal { get; init; }
    public LibraryContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=library;")
                .LogTo(Console.WriteLine);

    }
}