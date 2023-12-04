using MediatR;

namespace Application.Repositories.Command.Books.Delete
{
    public record DeleteBookCommand(int Id) : IRequest
    {
    }
}
