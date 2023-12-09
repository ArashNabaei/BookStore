using Domain.Repositories;
using Infrastructure.Repositories.Write.Authors;
using Infrastructure.Repositories.Write.Books;
using Infrastructure.Repositories.Write.Customers;
using Infrastructure.Repositories.Write.Publishers;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFConnection _eFConnection;

        private IDbContextTransaction _transaction;

        private IWriteAuthorRepository _authorRepository;
        public IWriteAuthorRepository AuthorRepository
        {
            get
            {
                return _authorRepository ??= new WriteAuthorRepository(_eFConnection);
            }
        }

        private IWriteBookRepository _bookRepository;
        public IWriteBookRepository BookRepository
        {
            get
            {
                return _bookRepository ??= new WriteBookRepository(_eFConnection);
            }
        }

        private IWriteCustomerRepository _customerRepository;
        public IWriteCustomerRepository CustomerRepository
        {
            get
            {
                return _customerRepository ??= new WriteCustomerRepository(_eFConnection);
            }
        }

        private IWritePublisherRepository _publisherRepository;
        public IWritePublisherRepository PublisherRepository
        {
            get
            {
                return _publisherRepository ??= new WritePublisherRepository(_eFConnection);
            }
        }

        public UnitOfWork(EFConnection eFConnection)
        {
            _eFConnection = eFConnection;
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _eFConnection.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
                await _transaction.CommitAsync();
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
                await _transaction.RollbackAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _eFConnection.SaveChangesAsync();
        }

    }
}
