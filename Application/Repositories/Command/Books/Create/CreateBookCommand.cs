using MediatR;

namespace Application.Repositories.Command.Books.Create
{
    public record CreateBookCommand(int Id, string Name, float Price, string Genre) : IRequest<int>
    {

    }
}
