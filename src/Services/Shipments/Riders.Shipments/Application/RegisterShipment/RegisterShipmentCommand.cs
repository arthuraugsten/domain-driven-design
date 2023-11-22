using MediatR;

namespace Riders.Shipments.Application.RegisterShipment;

public sealed record RegisterShipmentCommand(
    string Street,
    string City,
    string State,
    string Country,
    string Phone,
    string PostalCode,
    IEnumerable<ShipmentItemDto> Items
) : IRequest<RegisterShipmentCommandResult>;

public sealed record ShipmentItemDto(string Description, decimal Quantity, decimal UnitPrice);
