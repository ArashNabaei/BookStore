using Application.Services.Write.Authors;
using Domain.Repositories;
using MediatR;

namespace Application.Repositories.Command.Authors.Delete
{
    public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, int>
    {
        private readonly IWriteAuthorService _writeAuthorService;

        public DeleteAuthorCommandHandler(IWriteAuthorService writeAuthorService)
        {
            _writeAuthorService = writeAuthorService;
        }

        public async Task<int> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            
            await _writeAuthorService.DeleteAuthorAsync(request.Id);
            
            return request.Id;
        }

    }
}
