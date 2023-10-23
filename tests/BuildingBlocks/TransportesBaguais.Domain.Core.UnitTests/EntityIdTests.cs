namespace TransportesBaguais.Domain.Core.UnitTests;

public sealed class EntityIdTests
{
    [Fact]
    public void Value_Should_Be_Not_Null_When_Object_Created()
        => new MyId().Value.Should().NotBeEmpty();

    private sealed record MyId : EntityId { }
}