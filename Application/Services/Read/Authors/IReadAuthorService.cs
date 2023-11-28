using Application.DTOs;

namespace Application.Services.Read.Authors
{
    public interface IReadAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAllAuthorsAsync();

        Task<AuthorDTO> GetAuthorByIdAsync(int Id);

        Task<IEnumerable<BookDTO>> GetBooksOfAuhorByIdAsync(int Id);

    }
}
