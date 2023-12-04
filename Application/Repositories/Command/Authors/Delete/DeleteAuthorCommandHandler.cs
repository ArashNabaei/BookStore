using Application.Services.Write.Authors;
using MediatR;

namespace Application.Repositories.Command.Authors.Delete
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand>
    {
        private readonly IWriteAuthorService _writeAuthorService;

        public DeleteAuthorCommandHandler(IWriteAuthorService writeAuthorService)
        {
            _writeAuthorService = writeAuthorService;
        }

        public async Task Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            await _writeAuthorService.DeleteAuthorAsync(request.Id);
        }

    }
}
