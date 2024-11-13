using Customers.Api.Contracts.Requests;
using Customers.Api.Contracts.Responses;
using Customers.Api.Mapping;
using Customers.Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Customers.Api.Endpoints
{
    [HttpPut("customers/{id:guid}"), AllowAnonymous]
    public class UpdateCustomerEndpoint(ICustomerService _customerService) : Endpoint<UpdateCustomerRequest, CustomerResponse>
    {
        public override async Task HandleAsync(UpdateCustomerRequest req, CancellationToken ct)
        {
            var customer = req.ToCustomer();

            var updated = await _customerService.UpdateAsync(customer);
            if (!updated)
            {
                await SendNotFoundAsync(ct);
                return;
            }

            var response = customer.ToCustomerResponse();
            await SendOkAsync(response, ct);
        }
    }
}