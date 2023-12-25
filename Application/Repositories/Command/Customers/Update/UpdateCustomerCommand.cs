using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Command.Customers.Update
{
    public record UpdateCustomerCommand(int Id, string Username, string Password, float Balance) : IRequest
    {
    }
}
