using System;

namespace TransportesBaguais.Domain.Core;

// TODO: Convert to ID as Value Object. (On Goining...)
public abstract class Entity<TId> : IEquatable<Entity<TId>>
    where TId : EntityId, new()
{
    public TId Id { get; protected set; } = new();

    public override bool Equals(object? obj) => Equals(obj as Entity<TId>);

    public bool Equals(Entity<TId>? other)
    {
        if (ReferenceEquals(this, other))
            return true;

        if (other is null)
            return false;

        return Id.Value.Equals(other.Id);
    }

    public override int GetHashCode() => GetType().GetHashCode() + (Id?.GetHashCode() ?? 0);

    public static bool operator ==(Entity<TId>? a, Entity<TId>? b)
    {
        if (a is null && b is null)
            return true;

        if (a is null || b is null)
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(Entity<TId>? a, Entity<TId>? b)
        => !(a == b);
}