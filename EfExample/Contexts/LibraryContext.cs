using System;
using EfExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExample.Contexts;

public class LibraryContext : DbContext
{
	public DbSet<Author> Authors { get; init; }
	public DbSet<Book> Books { get; init; }
	public DbSet<BookAmount> BookAmounts { get; init; }
	public DbSet<Customer> Customers { get; init; }
	public DbSet<HistoryEntry> HistoryEntries { get; init; }

	public LibraryContext() : base() {}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("User ID=postgres;Password=12345;Host=localhost;Port=5432;Database=myDB;")
			.LogTo(Console.WriteLine)
			;
	}
}