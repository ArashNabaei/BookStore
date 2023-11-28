using Application.DTOs;
using MediatR;

namespace Application.Repositories.Query.Customers
{
    public record GetBooksOfCustomerByIdQuery : IRequest<IEnumerable<BookDTO>>
    {
        public int Id { get; set; }
    }
}
