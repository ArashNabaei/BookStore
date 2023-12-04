using MediatR;

namespace Application.Repositories.Command.Customers.Delete
{
    public record DeleteCustomerCommand(int Id) : IRequest
    {
    }
}
