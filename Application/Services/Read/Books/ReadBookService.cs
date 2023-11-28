using Application.DTOs;
using Domain.Repositories;

namespace Application.Services.Read.Books
{
    public class ReadBookService : IReadBookService
    {

        private readonly IReadBookRepository _readBookRepository;

        public ReadBookService(IReadBookRepository readBookRepository)
        {
            _readBookRepository = readBookRepository;
        }

        public async Task<IEnumerable<BookDTO>> GetAllBooksAsync()
        {
            var books = await _readBookRepository.GetAllBooksAsync();

            var result = books.Select(book => new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price,
                Genre = book.Genre
            });

            return result;
        }

        public async Task<BookDTO> GetBookByIdAsync(int id)
        {
            var book = await _readBookRepository.GetBookByIdAsync(id);

            var result = new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price,
                Genre = book.Genre
            };

            return result;
        }

    }

}
