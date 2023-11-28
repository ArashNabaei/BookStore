using Application.DTOs;
using Application.Services.Read.Customers;
using MediatR;

namespace Application.Repositories.Query.Customers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDTO>
    {

        private readonly IReadCustomerService _readCustomerService;

        public GetCustomerByIdQueryHandler(IReadCustomerService readCustomerService)
        {
            _readCustomerService = readCustomerService;
        }

        public async Task<CustomerDTO> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _readCustomerService.GetCustomerByIdAsync(request.Id);

            return customer;
        }
    }
}
