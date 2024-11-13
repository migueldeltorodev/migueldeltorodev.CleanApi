namespace Customers.Api.Contracts.Responses
{
    public record CustomerResponse(
        Guid Id,
        string Username,
        string FullName,
        string Email,
        DateTime DateOfBirth);
}