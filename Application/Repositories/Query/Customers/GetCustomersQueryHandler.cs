using Application.DTOs;
using Application.Services.Read.Customers;
using MediatR;

namespace Application.Repositories.Query.Customers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerDTO>>
    {

        private readonly IReadCustomerService _readCustomerService;

        public GetCustomersQueryHandler(IReadCustomerService readCustomerService)
        {
            _readCustomerService = readCustomerService;
        }

        public async Task<IEnumerable<CustomerDTO>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var result = await _readCustomerService.GetAllCustomersAsync();

            return result.ToList();
        }
    }
}
