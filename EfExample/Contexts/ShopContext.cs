using System;
using EfExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfExample.Contexts;

public class ShopContext : DbContext
{
	public DbSet<Customer> Customers { get; init; }
	public DbSet<Employee> Employees { get; init; }
	public DbSet<Position> Positions { get; init; }
	public DbSet<Product> Products { get; init; }
	public DbSet<Receipt> Receipts { get; init; }

	public ShopContext() : base()
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=shop;")
			.LogTo(Console.WriteLine)
			;
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Employee>()
			.HasOne<Position>(x => x.Position)
			.WithMany(x => x.Employees);

		base.OnModelCreating(modelBuilder);
	}
}