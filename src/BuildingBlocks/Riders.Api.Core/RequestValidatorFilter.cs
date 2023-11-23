using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Riders.Shipments.Api;

public sealed class RequestValidatorFilter<T>(IValidator<T> _validator) : IEndpointFilter
    where T : class
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        if (context.Arguments.SingleOrDefault(a => a?.GetType() == typeof(T)) is not T request)
        {
            return Results.BadRequest(); // Add an error message with a default object
        }

        var validationResult = await _validator.ValidateAsync(request);

        if (!validationResult.IsValid)
        {
            return Results.BadRequest(); // Add validation errors result with a default object
        }

        return await next(context);
    }
}
