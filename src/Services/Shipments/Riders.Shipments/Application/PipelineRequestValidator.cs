using FluentValidation;
using MediatR;

namespace Riders.Shipments.Application;

public class PipelineRequestValidator<TRequest, TResponse>(IEnumerable<IValidator<TRequest>> validators)
        : IPipelineBehavior<TRequest, TResponse?> where TRequest : IRequest<TResponse?>
{
    public async Task<TResponse?> Handle(TRequest request, RequestHandlerDelegate<TResponse?> next, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(next);
        
        var context = new ValidationContext<TRequest>(request);

        foreach (var validator in validators ?? [])
        {
            if (await validator.ValidateAsync(context, cancellationToken) is { IsValid: false } validationResult)
            {
                foreach (var error in validationResult.Errors.Where(t => t is not null))
                {
                    // Add a request context to pass the error messages to the API
                }

                return default;
            }
        }

        return await next();
    }
}
