using Application.DTOs;
using Application.Repositories.Query.Authors;
using Application.Services.Read.Authors;
using Application.Services.Read.Publishers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
