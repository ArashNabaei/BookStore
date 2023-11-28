using Domain.Entities;

namespace Domain.Repositories
{
    public interface IReadBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();

        Task<Book> GetBookByIdAsync(int Id);

    }
}
