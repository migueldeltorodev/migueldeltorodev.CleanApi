using Customers.Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Customers.Api.Endpoints
{
    [HttpDelete("customers/{id:guid}"), AllowAnonymous]
    public class DeleteCustomerEndpoint(ICustomerService _customerService) : EndpointWithoutRequest
    {
        public override async Task HandleAsync(CancellationToken ct)
        {
            var id = Route<Guid>("id");

            var deleted = await _customerService.DeleteAsync(id);
            if (!deleted)
            {
                await SendNotFoundAsync(ct);
                return;
            }

            await SendNoContentAsync(ct);
        }
    }
}