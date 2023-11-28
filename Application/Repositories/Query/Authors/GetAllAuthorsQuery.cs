using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Authors
{
    public record GetAllAuthorsQuery : IRequest<IEnumerable<AuthorDTO>>;
}
