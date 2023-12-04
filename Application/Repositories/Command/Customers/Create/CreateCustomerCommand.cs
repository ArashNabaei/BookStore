using MediatR;

namespace Application.Repositories.Command.Customers.Create
{
    public record CreateCustomerCommand(string Username, string Password, float Balance, int Orders) : IRequest
    {

    }
}
