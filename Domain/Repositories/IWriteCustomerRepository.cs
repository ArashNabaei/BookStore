using Domain.Entities;

namespace Domain.Repositories
{
    public interface IWriteCustomerRepository
    {
        Task CreateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(int id);

        Task UpdateCustomerAsync(int id , Customer customer);

        Task BuyBookForCustomer(int customerId, int bookId);

        Task Deposit(int id, float amount);

    }
}
