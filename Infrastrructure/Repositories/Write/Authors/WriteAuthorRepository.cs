using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories.Write.Authors
{
    public class WriteAuthorRepository : IWriteAuthorRepository
    {

        private readonly EFConnection _eFConnection;

        public WriteAuthorRepository(EFConnection eFConnection)
        {
           _eFConnection = eFConnection;
        }

        public async Task CreateAuthorAsync(Author author)
        {
            try
            {
                await _eFConnection.Authors.AddAsync(author);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task DeleteAuthorAsync(int id)
        {
            try
            {
                var authorToDelete = await _eFConnection.Authors.FindAsync(id);

                if (authorToDelete != null)
                    _eFConnection.Authors.Remove(authorToDelete);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
