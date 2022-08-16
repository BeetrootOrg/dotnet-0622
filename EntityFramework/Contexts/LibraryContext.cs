using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models;

class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Librarian> Librarians { get; set; }
    public DbSet<Loan> Loans { get; set; }
    public DbSet<Publisher> Publishers { get; set; }


    public LibraryContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=root;Password=myPassword;Host=localhost;Port=5432;Database=myDataBase;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne<Author>(x => x.AuthorId)
            .WithOne();
        modelBuilder.Entity<Book>()
            .HasOne<Publisher>(x => x.PublisherId)
            .WithOne();
        modelBuilder.Entity<Loan>()
            .HasOne<Customer>(x => x.CustomerId)
            .WithOne();
        modelBuilder.Entity<Loan>()
            .HasOne<Book>(x => x.BookId)
            .WithOne();
        modelBuilder.Entity<Loan>()
            .HasOne<Librarian>(x => x.LibrarianId)
            .WithOne();
        base.OnModelCreating(modelBuilder);
    }

}