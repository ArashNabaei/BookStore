using Application.Services.Write.Customers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Customers.Update
{
    public class DepositCommandHandler : IRequestHandler<DepositCommand>
    {
        private readonly IWriteCustomerService _writeCustomerService;

        public DepositCommandHandler(IWriteCustomerService writeCustomerService)
        {
            _writeCustomerService = writeCustomerService;
        }

        public async Task Handle(DepositCommand request, CancellationToken cancellationToken)
        {
            await _writeCustomerService.Deposit(request.Id, request.Amount);
        }

    }
}
