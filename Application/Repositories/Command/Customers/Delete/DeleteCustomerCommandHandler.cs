using Application.Services.Write.Customers;
using Domain.Repositories;
using MediatR;

namespace Application.Repositories.Command.Customers.Delete
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, int>
    {
        private readonly IWriteCustomerService _writeCustomerService;

        public DeleteCustomerCommandHandler(IWriteCustomerService writeCustomerService)
        {
            _writeCustomerService = writeCustomerService;
        }

        public async Task<int> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {

            await _writeCustomerService.DeleteCustomerAsync(request.Id);

            return request.Id;
        }

    }
}
