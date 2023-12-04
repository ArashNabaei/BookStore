using Application.Services.Write.Customers;
using MediatR;

namespace Application.Repositories.Command.Customers.Delete
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly IWriteCustomerService _writeCustomerService;

        public DeleteCustomerCommandHandler(IWriteCustomerService writeCustomerService)
        {
            _writeCustomerService = writeCustomerService;
        }

        public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            await _writeCustomerService.DeleteCustomerAsync(request.Id);
        }

    }
}
