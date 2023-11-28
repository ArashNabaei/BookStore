using MediatR;

namespace Application.Repositories.Command.Customers.Create
{
    public record CreateCustomerCommand(int Id, string Username, string Password, float Balance, int Orders) : IRequest<int>
    {

    }
}
