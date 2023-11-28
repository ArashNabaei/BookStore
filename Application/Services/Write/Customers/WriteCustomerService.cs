using Application.DTOs;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Write.Customers
{
    public class WriteCustomerService : IWriteCustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public WriteCustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateCustomerAsync(CustomerDTO customerDTO)
        {
            var customer = new Customer
            {
                Id = customerDTO.Id,
                Username = customerDTO.Username,
                Password = customerDTO.Password,
                Balance = customerDTO.Balance,
                Orders = customerDTO.Orders
            };

            await _unitOfWork.CustomerRepository.CreateCustomerAsync(customer);
            await _unitOfWork.Save();
        }

        public async Task DeleteCustomerAsync(int id)
        {
            await _unitOfWork.CustomerRepository.DeleteCustomerAsync(id);
            await _unitOfWork.Save();

        }

        public async Task BuyBookForCustomer(int customerId, int bookId)
        {
            await _unitOfWork.CustomerRepository.BuyBookForCustomer(customerId, bookId);
            await _unitOfWork.Save();
        }

    }

}
