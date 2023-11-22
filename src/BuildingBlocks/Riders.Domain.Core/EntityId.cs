namespace Riders.Domain.Core;

public abstract record EntityId(Guid Value)
{
    public EntityId() : this(Guid.NewGuid()) { }
}