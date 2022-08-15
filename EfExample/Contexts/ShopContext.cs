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
			.WithMany(x => x.Employees)
			.HasForeignKey(x => x.PositionId)
			.IsRequired();

		modelBuilder.Entity<Employee>()
			.HasMany<Receipt>(x => x.Receipts)
			.WithOne(x => x.Employee)
			.HasForeignKey(x => x.EmployeeId);

		modelBuilder.Entity<Customer>()
			.HasMany<Receipt>(x => x.Receipts)
			.WithOne(x => x.Customer)
			.HasForeignKey(x => x.CustomerId);

		modelBuilder.Entity<Receipt>()
			.HasMany<Product>(x => x.Products)
			.WithMany(x => x.Receipts)
			.UsingEntity<ReceiptProduct>(
				builder =>
					builder.HasOne<Product>(x => x.Product)
						.WithMany()
						.HasForeignKey(x => x.ProductId)
						.IsRequired(),
				builder =>
					builder.HasOne<Receipt>(x => x.Receipt)
						.WithMany()
						.HasForeignKey(x => x.ReceiptId)
						.IsRequired());

		base.OnModelCreating(modelBuilder);
	}
}