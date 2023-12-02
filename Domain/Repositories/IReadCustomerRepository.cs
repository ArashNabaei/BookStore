using Domain.Entities;

namespace Domain.Repositories
{
    public interface IReadCustomerRepository
    {

        Task<IEnumerable<Customer>> GetAllCustomersAsync();

        Task<Customer> GetCustomerByIdAsync(int id);

        Task<IEnumerable<Book>> GetBooksOfCustomerByIdAsync(int id);

    }
}
