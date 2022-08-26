using System;
using EfExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExample.Contexts;

public class LibraryContext : DbContext
{
	public DbSet<Author> Authors { get; init; }
	public DbSet<Book> Books { get; init; }
	public DbSet<Customer> Customers { get; init; }
	public DbSet<BookStore> BookStores { get; init; }
	public DbSet<MainJournal> MainJournals { get; init; }

	public LibraryContext() : base()
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("User ID=postgres;Password=qwerty;Host=localhost;Port=5432;Database=library;")
			//.LogTo(Console.WriteLine)
			;
	}
}