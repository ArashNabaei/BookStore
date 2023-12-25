using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWriteBookRepository
    {
        Task CreateBookAsync(Book book);

        Task DeleteBookAsync(int id);

        Task UpdateBookAsync(int id, Book book);

    }
}
