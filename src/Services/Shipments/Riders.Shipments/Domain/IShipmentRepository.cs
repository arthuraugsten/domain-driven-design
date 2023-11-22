using Riders.Data.Core.Contracts;

namespace Riders.Shipments.Domain;

public interface IShipmentRepository : IRepository
{
    void Add(Shipment shipment);
}
