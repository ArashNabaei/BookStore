using Application.DTOs;

namespace Application.Services.Read.Customers
{
    public interface IReadCustomerService
    {

        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();

        Task<CustomerDTO> GetCustomerByIdAsync(int id);

        Task<IEnumerable<BookDTO>> GetBooksOfCustomerByIdAsync(int id);

    }
}
