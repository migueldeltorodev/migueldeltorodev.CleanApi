namespace Customers.Api.Contracts.Data
{
    public record CustomerDto(
        Guid Id,
        string Username,
        string FullName,
        string Email,
        DateTime DateOfBirth);
}