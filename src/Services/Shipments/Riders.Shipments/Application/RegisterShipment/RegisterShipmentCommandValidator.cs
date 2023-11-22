using FluentValidation;

namespace Riders.Shipments.Application.RegisterShipment;

internal sealed class RegisterShipmentCommandValidator : AbstractValidator<RegisterShipmentCommand>
{
    public RegisterShipmentCommandValidator()
    {
        RuleFor(t => t.Items).NotEmpty();

        RuleFor(t => t.Street)
            .NotEmpty()
            .MinimumLength(5)
            .MaximumLength(255);

        RuleFor(t => t.Phone)
            .NotEmpty()
            .Length(13);

        RuleFor(t => t.City)
            .NotEmpty()
            .MinimumLength(5)
            .MaximumLength(255);

        RuleFor(t => t.Country)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(255);

        RuleFor(t => t.PostalCode)
            .NotEmpty()
            .MinimumLength(6)
            .MaximumLength(15);

        RuleFor(t => t.State)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(15);
    }
}
