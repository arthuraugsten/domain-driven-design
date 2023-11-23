using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Riders.Shipments.Domain;

namespace Riders.Shipments.Data;

internal sealed class ShipmentMap : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        builder.ToTable(nameof(Shipment));
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id).IsRequired();
        
        builder.ComplexProperty(t => t.Destination, complexBuilder =>
        {
            complexBuilder.Property(t => t.Street).HasMaxLength(250).IsRequired();
            complexBuilder.Property(t => t.PostalCode).HasMaxLength(250).IsRequired();
            complexBuilder.Property(t => t.City).HasMaxLength(250).IsRequired();
            complexBuilder.Property(t => t.Country).HasMaxLength(250).IsRequired();
            complexBuilder.Property(t => t.Phone).HasMaxLength(250).IsRequired();
            complexBuilder.Property(t => t.State).HasMaxLength(25).IsRequired();
        });

        builder.Property(t => t.CreatedAt).IsRequired();

        builder.Metadata.FindNavigation(nameof(Shipment.Items))?.SetPropertyAccessMode(PropertyAccessMode.Field);
    }
}
