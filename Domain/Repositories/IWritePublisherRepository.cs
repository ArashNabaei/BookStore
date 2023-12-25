using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWritePublisherRepository
    {
        Task CreatePublisherAsync(Publisher publisher);

        Task DeletePublisherAsync(int id);

        Task UpdatePublisherAsync(int id,  Publisher publisher);

    }
}
