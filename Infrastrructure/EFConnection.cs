using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata;

namespace Infrastructure
{
    public class EFConnection : DbContext, IDisposable
    {
        public EFConnection(DbContextOptions<EFConnection> options) : base(options)
        {
            this.OnModelCreating(new ModelBuilder());
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public IDbTransaction Transaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .HasOne(b => b.Customer)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.CustomerId);

            modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

        }

    }
}
