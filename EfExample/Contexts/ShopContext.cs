using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EfExample.Models;

namespace EfExample.Contexts
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCustomer> TblCustomers { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblPosition> TblPositions { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblReceipt> TblReceipts { get; set; }
        public virtual DbSet<TblReceiptsProduct> TblReceiptsProducts { get; set; }
        public virtual DbSet<ViewReceipt> ViewReceipts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=shop;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tbl_customers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tbl_employees");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_employees_position_id_fkey");
            });

            modelBuilder.Entity<TblPosition>(entity =>
            {
                entity.ToTable("tbl_positions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("tbl_products");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<TblReceipt>(entity =>
            {
                entity.ToTable("tbl_receipts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblReceipts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("tbl_receipts_customer_id_fkey");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TblReceipts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("tbl_receipts_employee_id_fkey");
            });

            modelBuilder.Entity<TblReceiptsProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_receipts_products");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ReceiptId).HasColumnName("receipt_id");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_receipts_products_product_id_fkey");

                entity.HasOne(d => d.Receipt)
                    .WithMany()
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_receipts_products_receipt_id_fkey");
            });

            modelBuilder.Entity<ViewReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_receipts");

                entity.Property(e => e.CustomerFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("customer_first_name");

                entity.Property(e => e.CustomerLastName)
                    .HasMaxLength(100)
                    .HasColumnName("customer_last_name");

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("employee_first_name");

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(50)
                    .HasColumnName("employee_last_name");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(500)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("money")
                    .HasColumnName("product_price");

                entity.Property(e => e.ReceiptId).HasColumnName("receipt_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
