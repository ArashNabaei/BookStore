using Domain.Repositories;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFConnection _eFConnection;

        public IWriteAuthorRepository AuthorRepository { get; }

        public IWriteBookRepository BookRepository { get; }

        public IWriteCustomerRepository CustomerRepository { get; }

        public IWritePublisherRepository PublisherRepository { get; }

        public UnitOfWork(EFConnection eFConnection, IWriteAuthorRepository authorRepository, IWriteBookRepository bookRepository, IWriteCustomerRepository customerRepository, IWritePublisherRepository publisherRepository)
        {
            _eFConnection = eFConnection;
            AuthorRepository = authorRepository;
            BookRepository = bookRepository;
            CustomerRepository = customerRepository;
            PublisherRepository = publisherRepository;
        }

        public void StartTransaction()
        {
            _eFConnection.transaction.Connection.BeginTransaction();
        }

        public void Commit()
        {
            _eFConnection.transaction.Commit();
        }

        public void Rollback()
        {
            _eFConnection.transaction.Rollback();
        }

        public async Task Save()
        {
            await _eFConnection.SaveChangesAsync();
        }
    }
}
