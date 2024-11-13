using Customers.Api.Domain;
using Customers.Api.Repositories;
using FluentValidation;

namespace Customers.Api.Services
{
    public class CustomerService(ICustomerRepository _customerRepository) : ICustomerService
    {
        public async Task<bool> CreateAsync(Customer customer)
        {
            // User Exists?
            var existingCustomer = await _customerRepository.GetAsync(customer.Id);
            if (existingCustomer is not null)
            {
                throw new ValidationException($"A customer with id {customer.Id} already exists");
            }
            // Email in Use?
            var customers = await _customerRepository.GetAllAsync();
            if (customers.Any(x => x.Email.Equals(customer.Email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ValidationException($"A customer with email {customer.Email} already exists");
            }

            return await _customerRepository.CreateAsync(customer);
        }

        public async Task<Customer?> GetAsync(Guid id)
        {
            return await _customerRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            // Verificar si existe
            var existingCustomer = await _customerRepository.GetAsync(customer.Id);
            if (existingCustomer is null)
            {
                return false;
            }

            return await _customerRepository.UpdateAsync(customer);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _customerRepository.DeleteAsync(id);
        }
    }
}