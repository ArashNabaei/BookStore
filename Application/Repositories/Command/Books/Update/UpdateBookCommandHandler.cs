using Application.DTOs;
using Application.Services.Write.Books;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Books.Update
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {

        private readonly IWriteBookService _writeBookService;

        public UpdateBookCommandHandler(IWriteBookService writeBookService)
        {
            _writeBookService = writeBookService;
        }

        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new BookDTO
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price,
                Genre = request.Genre
            };

            await _writeBookService.UpdateBookAsync(request.Id, book);
        }

    }
}
