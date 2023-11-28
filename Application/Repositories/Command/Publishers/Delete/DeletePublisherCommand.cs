using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Publishers.Delete
{
    public record DeletePublisherCommand(int Id) : IRequest<int>
    {
    }
}
