using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Write.Publishers
{
    public interface IWritePublisherService
    {

        Task CreatePublisherAsync(PublisherDTO publisherDTO);

        Task DeletePublisherAsync(int Id);

    }
}
