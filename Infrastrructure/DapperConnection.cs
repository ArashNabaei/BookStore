using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Infrastructure
{
    public class DapperConnection : IDisposable
    {
        public IDbConnection Connection { get; }

        private readonly IConfiguration _configuration;

        private bool disposed;

        public DapperConnection(IConfiguration configuration)
        {
            disposed = false;
            _configuration = configuration;
            Connection = new SqlConnection(this._configuration.GetConnectionString("MyDatabaseConnection"));
            Connection.Open();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (! disposed)
            {
                if (disposing)
                    Connection.Dispose();
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

    }
}
