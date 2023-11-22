namespace Riders.Shipments.Api;

public sealed record RegisterShipmentRequest(
    string Street,
    string City,
    string State,
    string Country,
    string Phone,
    string PostalCode,
    IEnumerable<ShipmentItemRequest> Items
);

public sealed record ShipmentItemRequest(string Description, decimal Quantity, decimal UnitPrice);