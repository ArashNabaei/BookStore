﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Infrastructure
{
    public class EFConnection : DbContext, IDisposable
    {
        public EFConnection(DbContextOptions<EFConnection> options) : base(options)
        {
            OnModelCreating(new ModelBuilder());
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

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
