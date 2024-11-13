using Customers.Api.Contracts.Data;
using Customers.Api.Database;
using Customers.Api.Domain;
using Customers.Api.Mapping;
using Dapper;

namespace Customers.Api.Repositories
{
    public class CustomerRepository(IDbConnectionFactory _connectionFactory) : ICustomerRepository
    {
        public async Task<bool> CreateAsync(Customer customer)
        {
            using var connection = await _connectionFactory.CreateConnectionAsync();
            var customerDto = customer.ToCustomerDto();

            var result = await connection.ExecuteAsync(
                @"INSERT INTO Customers (Id, Username, FullName, Email, DateOfBirth)
            VALUES (@Id, @Username, @FullName, @Email, @DateOfBirth)",
                customerDto);

            return result > 0;
        }

        public async Task<Customer?> GetAsync(Guid id)
        {
            using var connection = await _connectionFactory.CreateConnectionAsync();
            var customerDto = await connection.QuerySingleOrDefaultAsync<CustomerDto>(
                "SELECT * FROM Customers WHERE Id = @Id",
                new { Id = id.ToString() });

            return customerDto?.ToCustomer();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using var connection = await _connectionFactory.CreateConnectionAsync();
            var customerDtos = await connection.QueryAsync<CustomerDto>(
                "SELECT * FROM Customers");

            return customerDtos.Select(dto => dto.ToCustomer());
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            using var connection = await _connectionFactory.CreateConnectionAsync();
            var customerDto = customer.ToCustomerDto();

            var result = await connection.ExecuteAsync(
                @"UPDATE Customers
            SET Username = @Username,
                FullName = @FullName,
                Email = @Email,
                DateOfBirth = @DateOfBirth
            WHERE Id = @Id",
                customerDto);

            return result > 0;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            using var connection = await _connectionFactory.CreateConnectionAsync();
            var result = await connection.ExecuteAsync(
                "DELETE FROM Customers WHERE Id = @Id",
                new { Id = id.ToString() });

            return result > 0;
        }
    }
}