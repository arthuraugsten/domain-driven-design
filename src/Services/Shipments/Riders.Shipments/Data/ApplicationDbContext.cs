using Microsoft.EntityFrameworkCore;
using Riders.Shipments.Domain;

namespace Riders.Shipments.Data;

internal sealed class ApplicationDbContext : DbContext
{
    public DbSet<Shipment> Shipments => Set<Shipment>();
}
