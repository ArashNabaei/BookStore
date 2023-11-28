using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Publishers
{
    public record GetAllPublishersQuery: IRequest<IEnumerable<PublisherDTO>>;

}
