using MediatR;

namespace Application.Repositories.Command.Authors.Create
{
    public record CreateAuthorCommand(int Id, string Username, string Password) : IRequest<int>
    {
       
    }
}
