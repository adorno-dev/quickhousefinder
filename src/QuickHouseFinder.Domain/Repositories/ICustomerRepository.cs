using QuickHouseFinder.Domain.Entities;

namespace QuickHouseFinder.Domain.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>?> GetCustomers();
    Task<Customer?> GetCustomer(Guid id);
    Task<Customer?> AddCustomer(Customer customer);
    Task UpdateCustomer(Customer customer);
    Task DeleteCustomer(Guid id);
}