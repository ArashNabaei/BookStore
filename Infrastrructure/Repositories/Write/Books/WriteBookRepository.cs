using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories.Write.Books
{
    public class WriteBookRepository : IWriteBookRepository
    {

        private readonly EFConnection _eFConnection;

        public WriteBookRepository(EFConnection eFConnection)
        {
            _eFConnection = eFConnection;
        }

        public async Task CreateBookAsync(Book book)
        {
            try
            {
                await _eFConnection.Books.AddAsync(book);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task DeleteBookAsync(int id)
        {
            try
            {
                var bookToDelete = await _eFConnection.Books.FindAsync(id);

                if (bookToDelete != null)
                    _eFConnection.Books.Remove(bookToDelete);

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //public async Task<Book> GetBookByIdAsync(int id)
        //{
        //    try
        //    {
        //        var existingBook = await _eFConnection.Books.FindAsync(id);

        //        if (existingBook != null)
        //            return existingBook;

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    return new Book();
        //}


        //public async Task UpdateBookAsync(int id, Book book)
        //{
        //    var existingBook = await eFConnection.Books.FindAsync(id);

        //    if (existingBook != null)
        //    {
        //        existingBook.name = book.name;
        //        existingBook.price = book.price;
        //        existingBook.genre = book.genre;

        //    }

        //    await eFConnection.SaveChangesAsync();
        //}

    }
}
