using Application.DTOs;

namespace Application.Services.Read.Authors
{
    public interface IReadAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAuthorsAsync();

        Task<AuthorDTO> GetAuthorByIdAsync(int id);

        Task<IEnumerable<BookDTO>> GetBooksOfAuhorByIdAsync(int id);

    }
}
