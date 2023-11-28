using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Publishers
{
    public record GetPublisherByIdQuery(int Id) : IRequest<PublisherDTO>
    {
    }
}
