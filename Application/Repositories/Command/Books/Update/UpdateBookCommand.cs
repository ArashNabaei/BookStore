using MediatR;

namespace Application.Repositories.Command.Books.Update
{
    public record UpdateBookCommand(int Id, string Name, float Price, string Genre) : IRequest
    {
    }
}
