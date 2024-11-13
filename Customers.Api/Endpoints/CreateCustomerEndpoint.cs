using Customers.Api.Contracts.Requests;
using Customers.Api.Contracts.Responses;
using Customers.Api.Mapping;
using Customers.Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Customers.Api.Endpoints
{
    [HttpPost("customers"), AllowAnonymous]
    public class CreateCustomerEndpoint(ICustomerService _customerService) : Endpoint<CreateCustomerRequest, CustomerResponse>
    {
        public override async Task HandleAsync(CreateCustomerRequest req, CancellationToken ct)
        {
            var customer = req.ToCustomer();

            await _customerService.CreateAsync(customer);

            var response = customer.ToCustomerResponse();
            await SendCreatedAtAsync<GetCustomerEndpoint>(
                new { Id = customer.Id },
                response,
                generateAbsoluteUrl: true,
                cancellation: ct);
        }
    }
}