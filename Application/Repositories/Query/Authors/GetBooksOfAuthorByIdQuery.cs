using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Authors
{
    public record GetBooksOfAuthorByIdQuery : IRequest<IEnumerable<BookDTO>>
    {
        public int Id { get; set; }
    }
}
