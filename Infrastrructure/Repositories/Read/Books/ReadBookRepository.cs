using Dapper;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories.Read.Books
{
    public class ReadBookRepository : IReadBookRepository
    {

        private readonly DapperConnection _dapperConnection;

        public ReadBookRepository(DapperConnection dataBaseContext)
        {
            _dapperConnection = dataBaseContext;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            try 
            {
                string query = "SELECT * FROM Books;";
                return await _dapperConnection.Connection.QueryAsync<Book>(query);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                _dapperConnection.Dispose();
            }

            return new List<Book>();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            try 
            {
                string query = "SELECT * FROM Books WHERE Id = @id;";
                return await _dapperConnection.Connection.QueryFirstAsync<Book>(query, new { id });
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                _dapperConnection.Dispose();
            }

            return new Book();
        }

    }
}
