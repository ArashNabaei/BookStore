namespace Domain.Repositories
{
    public interface IUnitOfWork
    {
        IWriteAuthorRepository AuthorRepository { get; }


        IWriteBookRepository BookRepository { get; }

        IWriteCustomerRepository CustomerRepository { get; }

        IWritePublisherRepository PublisherRepository { get; }

        Task BeginTransactionAsync();

        Task CommitTransactionAsync();

        Task RollbackTransactionAsync();

        Task SaveChangesAsync();

    }
}
