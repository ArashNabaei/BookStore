using Application.DTOs;
using Domain.Repositories;
using Infrastructure.Repositories.Read.Authors;

namespace Application.Services.Read.Customers
{
    public class ReadCustomerService : IReadCustomerService
    {

        private readonly IReadCustomerRepository _readCustomerRepository;

        public ReadCustomerService(IReadCustomerRepository readCustomerRepository)
        {
            _readCustomerRepository = readCustomerRepository;
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync()
        {
            var customers = await _readCustomerRepository.GetAllCustomersAsync();

            var result = customers.Select(customer => new CustomerDTO
            {
                Id = customer.Id,
                Username = customer.Username,
                Password = customer.Password,
                Balance = customer.Balance,
                Orders = customer.Orders

            });

            return result;
        }

        public async Task<CustomerDTO> GetCustomerByIdAsync(int id)
        {
            var cutomer = await _readCustomerRepository.GetCustomerByIdAsync(id);

            var result = new CustomerDTO
            {
                Id = cutomer.Id,
                Username = cutomer.Username,
                Password = cutomer.Password,
                Balance = cutomer.Balance,
                Orders = cutomer.Orders
            };

            return result;
        }


        public async Task<IEnumerable<BookDTO>> GetBooksOfCustomerByIdAsync(int id)
        {
            var books = await _readCustomerRepository.GetBooksOfCustomerByIdAsync(id);

            var result = books.Select(book => new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                Price = book.Price,
                Genre = book.Genre
            });

            return result;
        }

    }

}
