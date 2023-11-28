using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories.Write.Publishers
{
    public class WritePublisherRepository : IWritePublisherRepository
    {

        private readonly EFConnection _eFConnection;

        public WritePublisherRepository(EFConnection eFConnection)
        {
            _eFConnection = eFConnection;
        }

        public async Task CreatePublisherAsync(Publisher publisher)
        {
            try
            {
                await _eFConnection.Publishers.AddAsync(publisher);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task DeletePublisherAsync(int id)
        {
            try
            {
                var publishersToDelete = await _eFConnection.Publishers.FindAsync(id);

                if (publishersToDelete != null)
                    _eFConnection.Publishers.Remove(publishersToDelete);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
