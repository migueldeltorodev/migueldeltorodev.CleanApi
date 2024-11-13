using Customers.Api.Contracts.Responses;
using Customers.Api.Domain;

namespace Customers.Api.Mapping
{
    public static class DomainToApiContractMapper
    {
        public static CustomerResponse ToCustomerResponse(this Customer customer)
        {
            return new CustomerResponse(
                customer.Id,
                customer.Username,
                customer.FullName,
                customer.Email,
                customer.DateOfBirth.ToDateTime(TimeOnly.MinValue));
        }

        public static GetAllCustomersResponse ToCustomersResponse(
            this IEnumerable<Customer> customers)
        {
            return new GetAllCustomersResponse(
            customers.Select(x => x.ToCustomerResponse()));
        }
    }
}