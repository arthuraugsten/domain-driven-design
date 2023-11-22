using Riders.Domain.Core;

namespace Riders.Shipments.Domain;

public sealed class Shipment : Entity<ShipmentId>, IAggregateRoot
{
    private readonly List<ShipmentItem> _items = [];

    public Shipment(Destination destination, List<ShipmentItem> items)
    {
        DomainArgumentException.ThrowIfNull(destination);

        if (items.Count == 0)
            throw new DomainArgumentException("Shipment cannot be created with zero items.");

        Destination = destination;
        _items = items;
    }

    public Destination Destination { get; private set; }
    public DateTime CreatedAt { get; init; } = DateTime.Now;

    public IReadOnlyList<ShipmentItem> Items => _items;
}
