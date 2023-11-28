using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Publishers.Create
{
    public record CreatePublisherCommand(int Id, string Name, string Address, string Information) : IRequest<int>
    {

    }
}
