using Application.Services.Write.Customers;
using MediatR;

namespace Application.Repositories.Command.Customers.Update
{
    public class BuyBookForCustomerCommandHanlder : IRequestHandler<BuyBookForCustomerCommand>
    {
        private readonly IWriteCustomerService _writeCustomerService;

        public BuyBookForCustomerCommandHanlder(IWriteCustomerService writeCustomerService)
        {
            _writeCustomerService = writeCustomerService;
        }

        public async Task Handle(BuyBookForCustomerCommand request, CancellationToken cancellationToken)
        {
            await _writeCustomerService.BuyBookForCustomer(request.CustomerId, request.BookId);
        }

    }
}
