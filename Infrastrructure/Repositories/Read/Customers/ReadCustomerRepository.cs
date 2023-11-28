using Dapper;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories.Read.Customers
{
    public class ReadCustomerRepository : IReadCustomerRepository
    {

        private readonly DapperConnection _dapperConnection;

        public ReadCustomerRepository(DapperConnection dataBaseContext)
        {
            _dapperConnection = dataBaseContext;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            try 
            {
                string query = "SELECT * FROM Customers;";
                return await _dapperConnection.Connection.QueryAsync<Customer>(query);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                _dapperConnection.Dispose();
            }

            return new List<Customer>();
        }


        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            try 
            {
                string query = "SELECT * FROM Customers WHERE Id = @id;";
                return await _dapperConnection.Connection.QueryFirstAsync<Customer>(query, new { id });
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                _dapperConnection.Dispose();
            }

            return new Customer();
        }

        public async Task<IEnumerable<Book>> GetBooksOfCustomerByIdAsync(int id)
        {
            try 
            {
                string query = "SELECT * FROM Books WHERE CustomerId = @id;";
                return await _dapperConnection.Connection.QueryAsync<Book>(query, new { id });
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

    }
}
