using MediatR;

namespace Application.Repositories.Command.Authors.Delete
{
    public record DeleteAuthorCommand(int Id) : IRequest<int>
    {
    }
}
