using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Query.Publishers
{
    public record GetPublisherByIdQuery(int Id) : IRequest<PublisherDTO>
    {
    }
}
