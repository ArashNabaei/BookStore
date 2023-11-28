using Application.DTOs;
using Application.Services.Read.Publishers;
using MediatR;

namespace Application.Repositories.Query.Publishers
{
    public class GetPublishersQueryHandler : IRequestHandler<GetAllPublishersQuery, IEnumerable<PublisherDTO>>
    {

        private readonly IReadPublisherService _readPublisherService;

        public GetPublishersQueryHandler(IReadPublisherService readPublisherService)
        {
            _readPublisherService = readPublisherService;
        }

        public async Task<IEnumerable<PublisherDTO>> Handle(GetAllPublishersQuery request, CancellationToken cancellationToken)
        {
            var result = await _readPublisherService.GetAllPublishersAsync();

            return result.ToList();
        }
    }
}
