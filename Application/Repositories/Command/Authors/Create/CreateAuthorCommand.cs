using MediatR;

namespace Application.Repositories.Command.Authors.Create
{
    public record CreateAuthorCommand(string Username, string Password) : IRequest<int>
    {
       
    }
}
