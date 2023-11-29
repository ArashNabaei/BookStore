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

        public async Task BuyBookForCustomer(int customerId, int bookId)
        {
            try
            {
                var exsitingCustomer = await _eFConnection.Customers.FindAsync(customerId);

                if (exsitingCustomer != null)
                    exsitingCustomer.Orders = bookId;
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

                if (existingCustomer != null)
                    existingCustomer.Balance += amount;
            }

            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
        }

        //public async Task<Customer> GetCustomerByIdAsync(int id)
        //{
        //    try
        //    {
        //        var existingCustomer = await _eFConnection.Customers.FindAsync(id);

        //        if (existingCustomer != null)
        //            return existingCustomer;

        //    }

        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    return new Customer();
        //}


        //public async Task UpdateCustomerAsync(int id, Customer customer)
        //{
        //    var existingCustomer = await eFConnection.Customers.FindAsync(id);

        //    if (existingCustomer != null)
        //    {
        //        existingCustomer.username = customer.username;
        //        existingCustomer.password = customer.password;
        //        existingCustomer.balance = customer.balance;
        //        existingCustomer.orders = customer.orders;
        //    }

        //    await eFConnection.SaveChangesAsync();
        //}

    }

}
