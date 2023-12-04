using MediatR;

namespace Application.Repositories.Command.Books.Create
{
    public record CreateBookCommand(string Name, float Price, string Genre) : IRequest
    {

    }
}
