using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Infrastructure
{
    public class EFConnection : DbContext, IDisposable
    {
        public EFConnection(DbContextOptions<EFConnection> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public IDbTransaction transaction { get; set; }

    }
}
