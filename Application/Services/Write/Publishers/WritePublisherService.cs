using Application.DTOs;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Write.Publishers
{
    public class WritePublisherService : IWritePublisherService
    {

        private readonly IUnitOfWork _unitOfWork;

        public WritePublisherService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreatePublisherAsync(PublisherDTO publisherDTO)
        {
            var publisher = new Publisher
            {
                Id = publisherDTO.Id,
                Name = publisherDTO.Name,
                Address = publisherDTO.Address,
                Information = publisherDTO.Information
            };

            await _unitOfWork.PublisherRepository.CreatePublisherAsync(publisher);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task DeletePublisherAsync(int id)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _unitOfWork.PublisherRepository.DeletePublisherAsync(id);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }

            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
            }

        }

        public async Task UpdatePublisherAsync(int id, PublisherDTO publisherDTO)
        {
            var publisher = new Publisher
            {
                Name = publisherDTO.Name,
                Address = publisherDTO.Address,
                Information = publisherDTO.Information
            };

            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _unitOfWork.PublisherRepository.UpdatePublisherAsync(id, publisher);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
            }
        }
    }
}
