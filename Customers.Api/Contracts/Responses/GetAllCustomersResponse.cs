namespace Customers.Api.Contracts.Responses
{
    public record GetAllCustomersResponse(
        IEnumerable<CustomerResponse> Customers);
}