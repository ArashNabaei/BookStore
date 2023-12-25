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
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(int id)
        {
            await _unitOfWork.CustomerRepository.DeleteCustomerAsync(id);
            await _unitOfWork.SaveChangesAsync();

        }

        public async Task UpdateCustomerAsync(int id, CustomerDTO customerDTO)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var customer = new Customer
                {
                    Username = customerDTO.Username,
                    Password = customerDTO.Password,
                    Balance = customerDTO.Balance
                };

                await _unitOfWork.CustomerRepository.UpdateCustomerAsync(id, customer);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
            }
        }

        public async Task BuyBookForCustomer(int customerId, int bookId)
        {
            await _unitOfWork.CustomerRepository.BuyBookForCustomer(customerId, bookId);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Deposit(int id, float amount)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _unitOfWork.CustomerRepository.Deposit(id, amount);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }

            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
            }
        }

    }

}
