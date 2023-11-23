using Riders.Domain.Core;

namespace Riders.Shipments.Domain;

public sealed class ShipmentItem(string description, decimal quantity, decimal unitPrice) : Entity<ShipmentId>(new(Guid.NewGuid()))
{
    private decimal? _total;

    public string Description { get; private set; } = description;
    public decimal Quantity { get; private set; } = quantity;
    public decimal UnitPrice { get; private set; } = unitPrice;
    public decimal Total => _total ??= Quantity * UnitPrice;
}
