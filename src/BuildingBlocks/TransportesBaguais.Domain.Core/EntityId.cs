namespace TransportesBaguais.Domain.Core;

public abstract record EntityId
{
    public Guid Value { get; protected set; } = Guid.NewGuid();
}