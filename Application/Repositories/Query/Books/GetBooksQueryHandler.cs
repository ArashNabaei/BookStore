using Application.DTOs;
using Application.Services.Read.Books;
using MediatR;

namespace Application.Repositories.Query.Books
{
    public class GetBooksQueryHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<BookDTO>>
    {

        private readonly IReadBookService _readBookService;

        public GetBooksQueryHandler(IReadBookService readBookService)
        {
            _readBookService = readBookService;
        }

        public async Task<IEnumerable<BookDTO>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var result = await _readBookService.GetAllBooksAsync();

            return result.ToList();
        }
    }
}
