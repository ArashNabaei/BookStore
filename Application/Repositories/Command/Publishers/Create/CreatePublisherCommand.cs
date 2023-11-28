using MediatR;

namespace Application.Repositories.Command.Publishers.Create
{
    public record CreatePublisherCommand(int Id, string Name, string Address, string Information) : IRequest<int>
    {

    }
}
