using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EfExample.Models;

namespace EfExample.Contexts
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

        public virtual DbSet<TblAuthor> TblAuthors { get; set; }
        public virtual DbSet<TblBook> TblBooks { get; set; }
        public virtual DbSet<TblGenre> TblGenres { get; set; }
        public virtual DbSet<TblReader> TblReaders { get; set; }
        public virtual DbSet<TblRent> TblRents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID=postgres;Password=H4g1A83;Host=localhost;Port=5432;Database=BookLibrary;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAuthor>(entity =>
            {
                entity.ToTable("tbl_authors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorFirstName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("author_first_name");

                entity.Property(e => e.AuthorLastName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("author_last_name");
            });

            modelBuilder.Entity<TblBook>(entity =>
            {
                entity.ToTable("tbl_books");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("book_name");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TblBooks)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("tbl_books_author_id_fkey");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.TblBooks)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_books_genre_id_fkey");
            });

            modelBuilder.Entity<TblGenre>(entity =>
            {
                entity.ToTable("tbl_genres");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("genre");
            });

            modelBuilder.Entity<TblReader>(entity =>
            {
                entity.ToTable("tbl_readers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ReaderFirstName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("reader_first_name");

                entity.Property(e => e.ReaderLastName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("reader_last_name");
            });

            modelBuilder.Entity<TblRent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_rents");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.HandOver)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("hand_over");

                entity.Property(e => e.Returned)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("returned");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_rents_book_id_fkey");

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_rents_customer_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
