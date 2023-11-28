using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWriteBookRepository
    {
        Task CreateBookAsync(Book book);

        Task DeleteBookAsync(int Id);

        // Task<Author> GetAuthorByIdAsync(int Id);

        // Task UpdateAuthorAsync(int id, Author author);

    }
}
