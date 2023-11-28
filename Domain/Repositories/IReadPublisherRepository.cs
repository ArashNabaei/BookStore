using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IReadPublisherRepository
    {


        Task<IEnumerable<Publisher>> GetAllPublishersAsync();

        Task<Publisher> GetPublisherByIdAsync(int Id);

    }
}
