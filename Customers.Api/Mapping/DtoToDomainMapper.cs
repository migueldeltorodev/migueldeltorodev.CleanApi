using Customers.Api.Contracts.Data;
using Customers.Api.Domain.Common;
using Customers.Api.Domain;

namespace Customers.Api.Mapping
{
    public static class DtoToDomainMapper
    {
        public static Customer ToCustomer(this CustomerDto customerDto)
        {
            return new Customer
            {
                Id = customerDto.Id,
                Username = customerDto.Username,
                FullName = customerDto.FullName,
                Email = customerDto.Email,
                DateOfBirth = DateOnly.FromDateTime(customerDto.DateOfBirth)
            };
        }
    }
}