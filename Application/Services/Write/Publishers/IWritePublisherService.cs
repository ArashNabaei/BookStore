using Application.DTOs;

namespace Application.Services.Write.Publishers
{
    public interface IWritePublisherService
    {

        Task CreatePublisherAsync(PublisherDTO publisherDTO);

        Task DeletePublisherAsync(int Id);

        Task UpdatePublisherAsync(int id,  PublisherDTO publisherDTO);

    }
}
