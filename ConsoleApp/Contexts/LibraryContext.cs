using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ConsoleApp.Models;

namespace ConsoleApp.Contexts
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

        public virtual DbSet<TblAuthor> TblAuthors { get; set; } = null!;
        public virtual DbSet<TblBook> TblBooks { get; set; } = null!;
        public virtual DbSet<TblGenre> TblGenres { get; set; } = null!;
        public virtual DbSet<TblReader> TblReaders { get; set; } = null!;
        public virtual DbSet<TblTransaction> TblTransactions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID=postgres;Password=bzik123;Host=localhost;Port=5432;Database=library");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAuthor>(entity =>
            {
                entity.ToTable("tbl_authors");

                entity.HasIndex(e => new { e.FirstName, e.LastName }, "tbl_authors_first_name_last_name_key")
                    .IsUnique();

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

                entity.Property(e => e.Author)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("author");

                entity.Property(e => e.Genre)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("genre");

                entity.Property(e => e.InitialQuantity)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("initial_quantity");

                entity.Property(e => e.Tittle)
                    .HasMaxLength(255)
                    .HasColumnName("tittle");

                entity.Property(e => e.Year)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("year");

                entity.HasOne(d => d.AuthorNavigation)
                    .WithMany(p => p.TblBooks)
                    .HasForeignKey(d => d.Author)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_books_author_fkey");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.TblBooks)
                    .HasForeignKey(d => d.Genre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_books_genre_fkey");
            });

            modelBuilder.Entity<TblGenre>(entity =>
            {
                entity.ToTable("tbl_genres");

                entity.HasIndex(e => e.Name, "tbl_genres_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblReader>(entity =>
            {
                entity.ToTable("tbl_readers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<TblTransaction>(entity =>
            {
                entity.ToTable("tbl_transactions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('tbl_borrowings_id_seq'::regclass)");

                entity.Property(e => e.Book)
                    .HasColumnName("book")
                    .HasDefaultValueSql("nextval('tbl_borrowings_book_seq'::regclass)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Reader)
                    .HasColumnName("reader")
                    .HasDefaultValueSql("nextval('tbl_borrowings_reader_seq'::regclass)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.BookNavigation)
                    .WithMany(p => p.TblTransactions)
                    .HasForeignKey(d => d.Book)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_borrowings_book_fkey");

                entity.HasOne(d => d.ReaderNavigation)
                    .WithMany(p => p.TblTransactions)
                    .HasForeignKey(d => d.Reader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_borrowings_reader_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
