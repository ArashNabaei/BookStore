using Domain.Entities;
using MediatR;

namespace Application.Repositories.Command.Authors.Update
{
    public record UpdateAuthorCommand(int Id, string UserName, string Password) : IRequest
    {
    }
}
