using System;
using EfExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExample.Contexts;

public class LibraryContext : DbContext
{
    public DbSet<Customer> Customers { get; init; }
    public DbSet<Author> Authors { get; init; }
    public DbSet<GetTime> GetTimes { get; init; }
    public DbSet<Book> Books { get; init; }

    public LibraryContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=postgres;Password=qwerty;Host=localhost;Port=5432;Database=Library;")
            .LogTo(Console.WriteLine)
            ;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne<Author>(x => x.Author)
            .WithMany(x => x.Books)
        .HasForeignKey(x => x.AuthorId)
        .IsRequired();

        modelBuilder.Entity<Author>()
            .HasMany<Book>(x => x.Books)
            .WithOne(x => x.Author)
            .HasForeignKey(x => x.AuthorId);

        modelBuilder.Entity<GetTime>()
           .HasMany<Book>(x => x.Books)
           .WithOne(x => x.GetTime)
           .HasForeignKey(x => x.Author);

        modelBuilder.Entity<GetTime>()
           .HasMany<Customer>(x => x.Customers)
           .WithOne(x => x.GetTime);

        modelBuilder.Entity<BookReturn>()
           .HasMany<Customer>(x => x.Customers)
           .WithOne(x => x.BookReturn);

        modelBuilder.Entity<BookReturn>()
           .HasMany<Book>(x => x.Books)
           .WithOne(x => x.BookReturn)
           .HasForeignKey(x => x.Author);

    }
}