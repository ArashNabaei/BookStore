using Application.DTOs;
using Application.Services.Read.Publishers;
using MediatR;

namespace Application.Repositories.Query.Publishers
{
    public class GetPublisherByIdQueryHandler : IRequestHandler<GetPublisherByIdQuery, PublisherDTO>
    {

        private readonly IReadPublisherService _readpublisherService;

        public GetPublisherByIdQueryHandler(IReadPublisherService readpublisherService)
        {
            _readpublisherService = readpublisherService;
        }

        public async Task<PublisherDTO> Handle(GetPublisherByIdQuery request, CancellationToken cancellationToken)
        {
            var publisher = await _readpublisherService.GetPublisherByIdAsync(request.Id);

            return publisher;
        }
    }
}
