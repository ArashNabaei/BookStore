using Application.DTOs;
using Application.Services.Write.Customers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Customers.Update
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {

        private readonly IWriteCustomerService _writeCustomerService;

        public UpdateCustomerCommandHandler(IWriteCustomerService writeCustomerService)
        {
            _writeCustomerService = writeCustomerService;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new CustomerDTO
            {
                Id = request.Id,
                Username = request.Username,
                Password = request.Password,
                Balance = request.Balance
            };

            await _writeCustomerService.UpdateCustomerAsync(request.Id, customer);
        }

    }
}
