using Application.DTOs;
using Application.Services.Read.Books;
using MediatR;

namespace Application.Repositories.Query.Books
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDTO>
    {

        private readonly IReadBookService _readBookService;

        public GetBookByIdQueryHandler(IReadBookService readBookService)
        {
            _readBookService = readBookService;
        }

        public async Task<BookDTO> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await _readBookService.GetBookByIdAsync(request.Id);

            return book;
        }
    }
}
