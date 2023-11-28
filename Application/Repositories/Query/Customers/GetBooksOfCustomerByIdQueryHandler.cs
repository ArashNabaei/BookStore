using Application.DTOs;
using Application.Repositories.Query.Authors;
using Application.Services.Read.Authors;
using Application.Services.Read.Customers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
