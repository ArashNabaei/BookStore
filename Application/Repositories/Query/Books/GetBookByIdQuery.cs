using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Books
{
    public record GetBookByIdQuery(int Id) : IRequest<BookDTO>
    {
    }
}
