﻿using Application.DTOs;
using Application.Services.Write.Authors;
using Domain.Repositories;
using MediatR;

namespace Application.Repositories.Command.Authors.Create
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, int>
    {

        private readonly IWriteAuthorService _writeAuthorService;

        public CreateAuthorCommandHandler(IWriteAuthorService writeAuthorService)
        {
            _writeAuthorService = writeAuthorService;
        }

        public async Task<int> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var newAuthor = new AuthorDTO
            {
                Id = request.Id,
                Username = request.Username,
                Password = request.Password
            };

            await _writeAuthorService.CreateAuthorAsync(newAuthor);

            return newAuthor.Id;

        }
    }

}