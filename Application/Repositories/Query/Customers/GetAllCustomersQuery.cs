using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Customers
{
    public record GetAllCustomersQuery : IRequest<IEnumerable<CustomerDTO>>;
}
