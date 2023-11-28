using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Books
{
    public record GetAllBooksQuery : IRequest<IEnumerable<BookDTO>>;
}
