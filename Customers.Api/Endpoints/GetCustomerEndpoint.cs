using Customers.Api.Contracts.Responses;
using Customers.Api.Mapping;
using Customers.Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Customers.Api.Endpoints
{
    [HttpGet("customers/{id:guid}"), AllowAnonymous]
    public class GetCustomerEndpoint(ICustomerService _customerService) : EndpointWithoutRequest<CustomerResponse>
    {
        public override async Task HandleAsync(CancellationToken ct)
        {
            var id = Route<Guid>("id");

            var customer = await _customerService.GetAsync(id);
            if (customer is null)
            {
                await SendNotFoundAsync(ct);
                return;
            }

            var response = customer.ToCustomerResponse();
            await SendOkAsync(response, ct);
        }
    }
}