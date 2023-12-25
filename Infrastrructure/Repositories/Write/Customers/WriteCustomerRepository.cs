using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories.Write.Customers
{
    public class WriteCustomerRepository : IWriteCustomerRepository
    {

        private readonly EFConnection _eFConnection;

        public WriteCustomerRepository(EFConnection eFConnection)
        {
            _eFConnection = eFConnection;
        }

        public async Task CreateCustomerAsync(Customer customer)
        {
            try
            {
                await _eFConnection.Customers.AddAsync(customer);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task DeleteCustomerAsync(int id)
        {
            try
            {
                var customerToDelete = await _eFConnection.Customers.FindAsync(id);

                if (customerToDelete != null)
                {
                    _eFConnection.Customers.Remove(customerToDelete);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task UpdateCustomerAsync(int id, Customer customer)
        {
            try
            {
                var existingCustomer = await _eFConnection.Customers.FindAsync(id);

                if (existingCustomer != null)
                {
                    existingCustomer.Username = customer.Username;
                    existingCustomer.Password = customer.Password;
                    existingCustomer.Balance = customer.Balance;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task BuyBookForCustomer(int customerId, int bookId)
        {
            try
            {
                var exsitingCustomer = await _eFConnection.Customers.FindAsync(customerId);
                var existingBook = await _eFConnection.Books.FindAsync(bookId);

                if (exsitingCustomer != null && existingBook != null)
                {
                    if (existingBook.Price >= exsitingCustomer.Balance)
                    {
                        exsitingCustomer.Orders = bookId;
                        exsitingCustomer.Balance -= existingBook.Price;
                    }
                        
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task Deposit(int id, float amount)
        {
            try
            {
                var existingCustomer = await _eFConnection.Customers.FindAsync(id);

                if (existingCustomer != null && amount > 0)
                    existingCustomer.Balance += amount;
            }

            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

}
