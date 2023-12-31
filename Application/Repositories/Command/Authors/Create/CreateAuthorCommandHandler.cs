﻿using Application.DTOs;
using Application.Services.Write.Authors;
using MediatR;

namespace Application.Repositories.Command.Authors.Create
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {

        private readonly IWriteAuthorService _writeAuthorService;

        public CreateAuthorCommandHandler(IWriteAuthorService writeAuthorService)
        {
            _writeAuthorService = writeAuthorService;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var newAuthor = new AuthorDTO
            {
                Username = request.Username,
                Password = request.Password
            };

            await _writeAuthorService.CreateAuthorAsync(newAuthor);
        }
    }

}
