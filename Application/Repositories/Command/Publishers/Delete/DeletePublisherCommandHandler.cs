using Application.Repositories.Command.Authors.Delete;
using Application.Services.Write.Authors;
using Application.Services.Write.Publishers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
