using Application.DTOs;
using Application.Services.Write.Authors;
using MediatR;

namespace Application.Repositories.Command.Authors.Update
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {

        private readonly IWriteAuthorService _writeAuthorService;

        public UpdateAuthorCommandHandler(IWriteAuthorService writeAuthorService)
        {
            _writeAuthorService = writeAuthorService;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = new AuthorDTO { 
                Id = request.Id,
                Username = request.UserName,
                Password = request.Password
            };

            await _writeAuthorService.UpdateAuthorAsync(request.Id, author);
        }

    }
}
