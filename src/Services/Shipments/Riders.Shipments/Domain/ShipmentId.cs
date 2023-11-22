using Riders.Domain.Core;

namespace Riders.Shipments.Domain;

public record ShipmentId(Guid Value) : EntityId(Value)
{
    public ShipmentId() : this(Guid.NewGuid()) { }
}
