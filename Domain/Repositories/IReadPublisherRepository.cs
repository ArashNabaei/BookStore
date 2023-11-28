using Domain.Entities;

namespace Domain.Repositories
{
    public interface IReadPublisherRepository
    {


        Task<IEnumerable<Publisher>> GetAllPublishersAsync();

        Task<Publisher> GetPublisherByIdAsync(int Id);

    }
}
