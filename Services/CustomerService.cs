using BusinessObjects;
using DataAccessLayer.DTO;
using Repositories;
using Repositories.Interface;
using Services.Interface;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository iCustomerRepository;

        public CustomerService()
        {
            iCustomerRepository = new CustomerRepository();
        }

        public void AddCustomer(CustomerDTO customer) => iCustomerRepository.AddCustomer(customer);

        public Customer? CheckLogin(string email, string password)
        {
            Customer? customer = GetCustomerByEmail(email);

            if (customer == null || !customer.Password.Equals(password))
            {
                return null;
            }

            return customer;
        }

        public void DeleteCustomer(int id) => iCustomerRepository.DeleteCustomer(id);

        public Customer? GetCustomerByEmail(string email) => iCustomerRepository.GetCustomerByEmail(email);

        public Customer? GetCustomerById(int id) => iCustomerRepository.GetCustomerById(id);

        public List<CustomerDTO> GetCustomers(Func<Customer, bool> predicate) => iCustomerRepository.GetCustomers(predicate);

        public void UpdateCustomer(CustomerDTO customer) => iCustomerRepository.UpdateCustomer(customer);

        public bool UpdateProfile(Customer customer) => iCustomerRepository.UpdateCustomer(customer);

        public int CountCustomers() => iCustomerRepository.CountCustomers();
    }
}
