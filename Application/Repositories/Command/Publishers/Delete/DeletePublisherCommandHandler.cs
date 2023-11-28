using Application.Services.Write.Publishers;
using MediatR;

namespace Application.Repositories.Command.Publishers.Delete
{
    public class DeletePublisherCommandHandler : IRequestHandler<DeletePublisherCommand, int>
    {
        private readonly IWritePublisherService _writePublisherService;

        public DeletePublisherCommandHandler(IWritePublisherService writePublisherService)
        {
            _writePublisherService = writePublisherService;
        }

        public async Task<int> Handle(DeletePublisherCommand request, CancellationToken cancellationToken)
        {

            await _writePublisherService.DeletePublisherAsync(request.Id);

            return request.Id;
        }

    }
}
