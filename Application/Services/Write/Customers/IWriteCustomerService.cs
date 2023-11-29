using Application.DTOs;

namespace Application.Services.Write.Customers
{
    public interface IWriteCustomerService
    {
        Task CreateCustomerAsync(CustomerDTO customerDTO);

        Task DeleteCustomerAsync(int Id);

        Task BuyBookForCustomer(int customerId, int bookId);

        Task Deposit(int id, float amount);

        //Task UpdateCustomerAsync(int id, CustomerDTO customerDTO);

    }
}
