using Customers.Api.Contracts.Requests;
using Customers.Api.Domain.Common;
using Customers.Api.Domain;

namespace Customers.Api.Mapping
{
    public static class ApiContractToDomainMapper
    {
        public static Customer ToCustomer(this CreateCustomerRequest request)
        {
            return new Customer
            {
                Username = request.Username,
                FullName = request.FullName,
                Email = request.Email,
                DateOfBirth = DateOnly.FromDateTime(request.DateOfBirth)
            };
        }

        public static Customer ToCustomer(this UpdateCustomerRequest request)
        {
            return new Customer
            {
                Id = request.Id,
                Username = request.Username,
                FullName = request.FullName,
                Email = request.Email,
                DateOfBirth = DateOnly.FromDateTime(request.DateOfBirth)
            };
        }
    }
}