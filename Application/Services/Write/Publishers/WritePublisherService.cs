using Application.DTOs;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            await _unitOfWork.Save();

        }

        public async Task DeletePublisherAsync(int id)
        {
            await _unitOfWork.PublisherRepository.DeletePublisherAsync(id);
            await _unitOfWork.Save();
        }


    }
}
