using Application.DTOs;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Read.Publishers
{
    public class ReadPublisherService : IReadPublisherService
    {
        private readonly IReadPublisherRepository _readPublisherRepository;

        public ReadPublisherService(IReadPublisherRepository readPublisherRepository)
        {
            _readPublisherRepository = readPublisherRepository;
        }

        public async Task<IEnumerable<PublisherDTO>> GetAllPublishersAsync()
        {
            var publishers = await _readPublisherRepository.GetAllPublishersAsync();

            var result = publishers.Select(publisher => new PublisherDTO
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Address = publisher.Address,
                Information = publisher.Information
            });

            return result;
        }

        public async Task<PublisherDTO> GetPublisherByIdAsync(int id)
        {
            var publisher = await _readPublisherRepository.GetPublisherByIdAsync(id);

            var result = new PublisherDTO
            {
                Id = publisher.Id,
                Name = publisher.Name,
                Address = publisher.Address,
                Information = publisher.Information
            };

            return result;
        }

    }
}
