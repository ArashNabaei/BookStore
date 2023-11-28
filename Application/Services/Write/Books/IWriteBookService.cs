using Application.DTOs;

namespace Application.Services.Write.Books
{
    public interface IWriteBookService
    {

        Task CreateBookAsync(BookDTO bookDTO);

        Task DeleteBookAsync(int Id);

    }
}
