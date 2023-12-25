using Application.DTOs;
using Application.Services.Write.Publishers;
using MediatR;

namespace Application.Repositories.Command.Publishers.Update
{
    public class UpdatePublisherCommandHandler : IRequestHandler <UpdatePublisherCommand>
    {

        private readonly IWritePublisherService _writePublisherService;

        public UpdatePublisherCommandHandler(IWritePublisherService writePublisherService)
        {
            _writePublisherService = writePublisherService;
        }

        public async Task Handle(UpdatePublisherCommand request, CancellationToken cancellationToken)
        {
            var publisher = new PublisherDTO 
                { Id = request.Id, 
                  Name = request.Name,
                  Address = request.Address,
                  Information = request.Information
                };

            await _writePublisherService.UpdatePublisherAsync(request.Id, publisher);
        }

    }
}
