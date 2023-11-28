using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Authors
{
    public record GetAuthorByIdQuery(int Id) : IRequest<AuthorDTO>
    {
    }
}
