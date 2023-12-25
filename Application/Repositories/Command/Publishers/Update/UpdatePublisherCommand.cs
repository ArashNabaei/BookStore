using MediatR;

namespace Application.Repositories.Command.Publishers.Update
{
    public record UpdatePublisherCommand(int Id, string Name, string Address, string Information) : IRequest
    {
    }
}
