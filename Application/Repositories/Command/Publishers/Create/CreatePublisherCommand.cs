using MediatR;

namespace Application.Repositories.Command.Publishers.Create
{
    public record CreatePublisherCommand(string Name, string Address, string Information) : IRequest
    {

    }
}
