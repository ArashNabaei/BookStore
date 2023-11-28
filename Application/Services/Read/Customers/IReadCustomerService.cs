using Application.DTOs;

namespace Application.Services.Read.Customers
{
    public interface IReadCustomerService
    {

        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();

        Task<CustomerDTO> GetCustomerByIdAsync(int Id);

        Task<IEnumerable<BookDTO>> GetBooksOfCustomerByIdAsync(int Id);

    }
}
