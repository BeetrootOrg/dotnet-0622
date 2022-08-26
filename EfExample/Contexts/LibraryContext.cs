using System;
using EfExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExample.Contexts;

public class LibraryContext : DbContext
{
	public DbSet<Authors> Authors { get; init; }
	public DbSet<Books> Books { get; init; }
	public DbSet<Customers> Customers { get; init; }
	public DbSet<Genres> Genres { get; init; }
	public DbSet<History> History { get; init; }

	public LibraryContext() : base()
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=library;")
			.LogTo(Console.WriteLine)
			;
	}

	// protected override void OnModelCreating(ModelBuilder modelBuilder)
	// {
	// 	modelBuilder.Entity<Employee>()
	// 		.HasOne<Position>(x => x.Position)
	// 		.WithMany(x => x.Employees);

	// 	base.OnModelCreating(modelBuilder);
	// }
}