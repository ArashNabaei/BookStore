using Dapper;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Read.Publishers
{
    public class ReadPublisherRepository : IReadPublisherRepository
    {

        private readonly DapperConnection _dapperConnection;

        public ReadPublisherRepository(DapperConnection dataBaseContext)
        {
            _dapperConnection = dataBaseContext;
        }

        public async Task<IEnumerable<Publisher>> GetAllPublishersAsync()
        {
            try
            {
                string query = "SELECT * FROM Publishers;";
                return await _dapperConnection.Connection.QueryAsync<Publisher>(query);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {

                _dapperConnection.Dispose();
            }

            return new List<Publisher>();
        }

        public async Task<Publisher> GetPublisherByIdAsync(int id)
        {
            try
            {
                string query = "SELECT * FROM Publishers WHERE Id = @id;";
                return await _dapperConnection.Connection.QueryFirstAsync<Publisher>(query, new { id });
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                _dapperConnection.Dispose();
            }

            return new Publisher();
        }

    }
}
