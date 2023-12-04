using MediatR;

namespace Application.Repositories.Command.Publishers.Delete
{
    public record DeletePublisherCommand(int Id) : IRequest
    {
    }
}
