namespace Customers.Api.Contracts.Requests
{
    public record CreateCustomerRequest(
        string Username,
        string FullName,
        string Email,
        DateTime DateOfBirth);
}