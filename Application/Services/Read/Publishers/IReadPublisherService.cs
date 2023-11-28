using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Read.Publishers
{
    public interface IReadPublisherService
    {

        Task<IEnumerable<PublisherDTO>> GetAllPublishersAsync();

        Task<PublisherDTO> GetPublisherByIdAsync(int Id);

    }
}
