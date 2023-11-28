using Domain.Entities;

namespace Domain.Repositories
{
    public interface IReadCustomerRepository
    {

        Task<IEnumerable<Customer>> GetAllCustomersAsync();

        Task<Customer> GetCustomerByIdAsync(int Id);

        Task<IEnumerable<Book>> GetBooksOfCustomerByIdAsync(int Id);

    }
}
