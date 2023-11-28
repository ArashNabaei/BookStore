using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWriteBookRepository
    {
        
        Task CreateBookAsync(Book book);

        Task DeleteBookAsync(int Id);

        // Task<Book> GetBookByIdAsync(int Id);

        //Task UpdateBookAsync(int id, Book book);

    }
}
