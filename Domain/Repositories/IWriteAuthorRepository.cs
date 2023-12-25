using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWriteAuthorRepository
    {
        Task CreateAuthorAsync(Author author);

        Task DeleteAuthorAsync(int id);

        Task UpdateAuthorAsync(int id, Author author);

    }
}
