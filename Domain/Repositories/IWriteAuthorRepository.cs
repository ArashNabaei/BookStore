using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWriteAuthorRepository
    {
        Task CreateAuthorAsync(Author author);

        Task DeleteAuthorAsync(int id);

        // Task<Author> GetAuthorByIdAsync(int Id);

        // Task UpdateAuthorAsync(int id, Author author);

    }
}
