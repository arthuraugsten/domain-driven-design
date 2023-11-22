using Riders.Shipments.Application.RegisterShipment;

namespace Riders.Shipments.Api;

internal static class RegisterShipmentRequestMapper
{
    internal static RegisterShipmentCommand ToCommand(RegisterShipmentRequest command)
    {
        ArgumentNullException.ThrowIfNull(command);

        return new RegisterShipmentCommand(
            command.Street, command.City, command.State, command.Country, command.Phone, command.PostalCode,
            command.Items?.Select(t => new ShipmentItemDto(t.Description, t.Quantity, t.UnitPrice)).ToList() ?? []
        );
    }
}
