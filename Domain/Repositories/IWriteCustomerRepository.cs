using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWriteCustomerRepository
    {
        Task CreateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(int Id);

        Task BuyBookForCustomer(int customerId, int bookId);

        Task Deposit(int id, float amount);

        // Task<Customer> GetCustomerByIdAsync(int Id);

        // Task UpdateCustomerAsync(int id, Customer customer);

    }
}
