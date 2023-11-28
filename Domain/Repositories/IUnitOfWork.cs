namespace Domain.Repositories
{
    public interface IUnitOfWork
    {
        IWriteAuthorRepository AuthorRepository { get; }

        IWriteBookRepository BookRepository { get; }

        IWriteCustomerRepository CustomerRepository { get; }

        IWritePublisherRepository PublisherRepository { get; }

        void StartTransaction();
        void Rollback();
        void Commit();
        Task Save();

    }
}
