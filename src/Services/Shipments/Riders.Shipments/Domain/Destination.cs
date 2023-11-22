using Riders.Domain.Core;

namespace Riders.Shipments.Domain;

public sealed record Destination
{
    public Destination(string street, string city, string state, string country, string phone, string postalCode)
    {
        DomainArgumentException.ThrowIfNullOrWhiteSpace(street);
        DomainArgumentException.ThrowIfNullOrWhiteSpace(city);
        DomainArgumentException.ThrowIfNullOrWhiteSpace(state);
        DomainArgumentException.ThrowIfNullOrWhiteSpace(country);
        DomainArgumentException.ThrowIfNullOrWhiteSpace(phone);
        DomainArgumentException.ThrowIfNullOrWhiteSpace(postalCode);

        Street = street;
        City = city;
        State = state;
        Country = country;
        Phone = phone;
        PostalCode = postalCode;
    }

    public string Street { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string Country { get; init; }
    public string Phone { get; init; }
    public string PostalCode { get; init; }
}
