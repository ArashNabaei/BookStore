using Application.DTOs;
using Application.Repositories.Command.Authors.Create;
using Application.Services.Write.Authors;
using Application.Services.Write.Publishers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Publishers.Create
{
    public class CreatePublisherCommandHandler : IRequestHandler<CreatePublisherCommand, int>
    {

        private readonly IWritePublisherService _writePublisherService;

        public CreatePublisherCommandHandler(IWritePublisherService writePublisherService)
        {
            _writePublisherService = writePublisherService;
        }

        public async Task<int> Handle(CreatePublisherCommand request, CancellationToken cancellationToken)
        {
            var newPublisher = new PublisherDTO
            {
                Id = request.Id,
                Name = request.Name,
                Address = request.Address,
                Information = request.Information
            };

            await _writePublisherService.CreatePublisherAsync(newPublisher);

            return newPublisher.Id;

        }
    }
}
