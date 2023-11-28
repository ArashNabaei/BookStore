using MediatR;

namespace Application.Repositories.Command.Customers.Update
{
    public record BuyBookForCustomerCommand(int CustomerId, int BookId) : IRequest
    {
    }
}
