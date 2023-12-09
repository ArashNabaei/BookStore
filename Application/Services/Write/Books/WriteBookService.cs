using Application.DTOs;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Write.Books
{
    public class WriteBookService : IWriteBookService
    {

        private readonly IUnitOfWork _unitOfWork;

        public WriteBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateBookAsync(BookDTO bookDTO)
        {
            var book = new Book
            {
                Id = bookDTO.Id,
                Name = bookDTO.Name,
                Price  = bookDTO.Price,
                Genre = bookDTO.Genre
            };

            await _unitOfWork.BookRepository.CreateBookAsync(book);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task DeleteBookAsync(int id)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _unitOfWork.BookRepository.DeleteBookAsync(id);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }

            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
            }
        }

    }
}
