using Application.DTOs;
using Application.Services.Read.Customers;
using MediatR;

namespace Application.Repositories.Query.Customers
{
    public class GetBooksOfCustomerByIdQueryHandler : IRequestHandler<GetBooksOfCustomerByIdQuery, IEnumerable<BookDTO>>
    {



        private readonly IReadCustomerService _readCustomerService;

        public GetBooksOfCustomerByIdQueryHandler(IReadCustomerService readCustomerService)
        {
            _readCustomerService = readCustomerService;
        }

        public async Task<IEnumerable<BookDTO>> Handle(GetBooksOfCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _readCustomerService.GetBooksOfCustomerByIdAsync(request.Id);

            return result.ToList();
        }

    }
}
