using Application.DTOs;

namespace Application.Services.Read.Publishers
{
    public interface IReadPublisherService
    {

        Task<IEnumerable<PublisherDTO>> GetAllPublishersAsync();

        Task<PublisherDTO> GetPublisherByIdAsync(int Id);

    }
}
