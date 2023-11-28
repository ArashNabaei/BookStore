using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Customers.Update
{
    public record BuyBookForCustomerCommand(int CustomerId, int BookId) : IRequest
    {
    }
}
