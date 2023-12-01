using Application.DTOs;
using Application.Services.Write.Customers;
using MediatR;

namespace Application.Repositories.Command.Customers.Create
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        private readonly IWriteCustomerService _writeCustomerService;

        public CreateCustomerCommandHandler(IWriteCustomerService writeCustomerService)
        {
            _writeCustomerService = writeCustomerService;
        }

        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {

            var newCustomer = new CustomerDTO
            {
                Username = request.Username,
                Password = request.Password,
                Balance = request.Balance,
                Orders = request.Orders
            };

            await _writeCustomerService.CreateCustomerAsync(newCustomer);

            return newCustomer.Id;

        }
    }

}
