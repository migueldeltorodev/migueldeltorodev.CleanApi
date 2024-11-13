namespace Customers.Api.Contracts.Requests
{
    public record UpdateCustomerRequest(
        Guid Id,
        string Username,
        string FullName,
        string Email,
        DateTime DateOfBirth);
}