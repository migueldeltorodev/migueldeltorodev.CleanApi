using Customers.Api.Contracts.Responses;
using FluentValidation;

namespace Customers.Api.Validation
{
    public class ValidationExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ValidationExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ValidationException exception)
            {
                context.Response.StatusCode = 400;
                var validationFailureResponse = new ValidationFailureResponse
                {
                    Errors = exception.Errors.Select(x => x.ErrorMessage).ToList()
                };
                await context.Response.WriteAsJsonAsync(validationFailureResponse);
            }
        }
    }
}