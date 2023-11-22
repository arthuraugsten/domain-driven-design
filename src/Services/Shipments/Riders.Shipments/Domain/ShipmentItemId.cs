using Riders.Domain.Core;

namespace Riders.Shipments.Domain;

public sealed record ShipmentItemId(Guid Value) : EntityId(Value)
{
    public ShipmentItemId() : this(Guid.NewGuid())
    { }
}
