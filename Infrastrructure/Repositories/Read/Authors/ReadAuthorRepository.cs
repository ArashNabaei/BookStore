using Dapper;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories.Read.Authors
{
    public class ReadAuthorRepository : IReadAuthorRepository
    {

        private readonly DapperConnection _dapperConnection;

        public ReadAuthorRepository(DapperConnection dataBaseContext)
        {
            _dapperConnection = dataBaseContext;
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            try
            {
                string query = "SELECT * FROM Authors;";
                return await _dapperConnection.Connection.QueryAsync<Author>(query);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally{

                _dapperConnection.Dispose();
            }

            return new List<Author>();
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            try 
            {
                string query = "SELECT * FROM Authors WHERE Id = @id;";
                return await _dapperConnection.Connection.QueryFirstAsync<Author>(query, new { id });
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally 
            { 
                _dapperConnection.Dispose(); 
            }

            return new Author();
        }

        public async Task<IEnumerable<Book>> GetBooksOfAuhorByIdAsync(int id)
        {
            try
            {
                string query = "SELECT * FROM Books WHERE AuthorId = @id;";
                return await _dapperConnection.Connection.QueryAsync<Book>(query, new { id });
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally 
            { 
                _dapperConnection.Dispose(); 
            }

            return new List<Book>();
        }

    }
}
