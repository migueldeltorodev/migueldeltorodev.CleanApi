using Customers.Api.Contracts.Data;
using Customers.Api.Domain;

namespace Customers.Api.Mapping
{
    public static class DomainToDtoMapper
    {
        public static CustomerDto ToCustomerDto(this Customer customer)
        {
            return new CustomerDto(
                customer.Id,
                customer.Username,
                customer.FullName,
                customer.Email,
                customer.DateOfBirth.ToDateTime(TimeOnly.MinValue));
        }
    }
}