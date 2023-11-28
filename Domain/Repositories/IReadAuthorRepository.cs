using Domain.Entities;

namespace Domain.Repositories
{
    public interface IReadAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthorsAsync();

        Task<Author> GetAuthorByIdAsync(int Id);

        Task<IEnumerable<Book>> GetBooksOfAuhorByIdAsync(int Id);

    }
}
