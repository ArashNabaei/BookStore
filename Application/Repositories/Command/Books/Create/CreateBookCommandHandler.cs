using Application.DTOs;
using Application.Services.Write.Books;
using MediatR;

namespace Application.Repositories.Command.Books.Create
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {

        private readonly IWriteBookService _writeBookService;

        public CreateBookCommandHandler(IWriteBookService writeBookService)
        {
            _writeBookService = writeBookService;
        }

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var newBook = new BookDTO
            {
                Name = request.Name,
                Price = request.Price,
                Genre = request.Genre,
            };

            await _writeBookService.CreateBookAsync(newBook);

            return newBook.Id;

        }
    }
}
