using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Customers
{
    public record GetCustomerByIdQuery(int Id) : IRequest<CustomerDTO>
    {
    }
}
