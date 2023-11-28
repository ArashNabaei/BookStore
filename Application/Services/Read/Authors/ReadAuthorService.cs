using Application.DTOs;
using Domain.Repositories;

namespace Application.Services.Read.Authors
{
    public class ReadAuthorService : IReadAuthorService
    {

        private readonly IReadAuthorRepository _readAuthorRepository;

        public ReadAuthorService(IReadAuthorRepository readAuthorRepository)
        {
            _readAuthorRepository = readAuthorRepository;
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthorsAsync()
        {
            var authors = await _readAuthorRepository.GetAllAuthorsAsync();

            var result = authors.Select(author => new AuthorDTO
            {
                Id = author.Id,
                Username = author.Username,
                Password = author.Password
            });

            return result;
        }

        public async Task<AuthorDTO> GetAuthorByIdAsync(int id)
        {
            var author = await _readAuthorRepository.GetAuthorByIdAsync(id);

            var result = new AuthorDTO
            {
                Id = author.Id,
                Username = author.Username,
                Password = author.Password,
            };

            return result;
        }

        public async Task<IEnumerable<BookDTO>> GetBooksOfAuhorByIdAsync(int id)
        {
            var books = await _readAuthorRepository.GetBooksOfAuhorByIdAsync(id);

            var result = books.Select(book => new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price,
                Genre = book.Genre
            });

            return result;
        }
    }

}
