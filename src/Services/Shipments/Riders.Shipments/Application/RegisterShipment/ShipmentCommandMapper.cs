using Riders.Shipments.Domain;

namespace Riders.Shipments.Application.RegisterShipment;

internal static class ShipmentCommandMapper
{
    internal static Shipment ToEntity(RegisterShipmentCommand command)
    {
        ArgumentNullException.ThrowIfNull(command);

        return new Shipment(
            new(command.Street, command.City, command.State, command.Country, command.Phone, command.PostalCode),
            command.Items?.Select(t => new ShipmentItem(t.Description, t.Quantity, t.UnitPrice)).ToList() ?? []
        );
    }

}
