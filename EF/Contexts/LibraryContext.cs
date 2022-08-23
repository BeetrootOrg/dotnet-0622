using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EF.Models;

namespace EF.Contexts
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAutor> TblAutors { get; set; } = null!;
        public virtual DbSet<TblBook> TblBooks { get; set; } = null!;
        public virtual DbSet<TblBooksCount> TblBooksCounts { get; set; } = null!;
        public virtual DbSet<TblCustomer> TblCustomers { get; set; } = null!;
        public virtual DbSet<TblLibrary> TblLibraries { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID=postgres;Password=qwerty;Host=localhost;Port=5432;Database=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

            modelBuilder.Entity<TblAutor>(entity =>
            {
                entity.ToTable("tbl_autors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<TblBook>(entity =>
            {
                entity.ToTable("tbl_books");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AutorId).HasColumnName("autor_id");

                entity.Property(e => e.BookGenre)
                    .HasMaxLength(255)
                    .HasColumnName("book_genre");

                entity.Property(e => e.BookName)
                    .HasMaxLength(255)
                    .HasColumnName("book_name");

                entity.Property(e => e.BookYear).HasColumnName("book_year");

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.TblBooks)
                    .HasForeignKey(d => d.AutorId)
                    .HasConstraintName("tbl_books_autor_id_fkey");
            });

            modelBuilder.Entity<TblBooksCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_books_count");

                entity.Property(e => e.BookCount)
                    .HasColumnName("book_count")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("tbl_books_count_book_id_fkey");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.ToTable("tbl_customers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<TblLibrary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_library");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.BookReturned).HasColumnName("book_returned");

                entity.Property(e => e.BookTaken)
                    .HasColumnName("book_taken")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("tbl_library_book_id_fkey");

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("tbl_library_customer_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
