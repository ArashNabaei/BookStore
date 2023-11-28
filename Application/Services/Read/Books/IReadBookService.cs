using Application.DTOs;

namespace Application.Services.Read.Books
{
    public interface IReadBookService
    {

        Task<IEnumerable<BookDTO>> GetAllBooksAsync();

        Task<BookDTO> GetBookByIdAsync(int Id);

    }
}
