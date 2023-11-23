namespace Riders.Domain.Core.UnitTests;

public sealed class EntityIdTests
{
    [Fact]
    public void Value_Should_Be_Not_Null_When_Object_Created_With_Parameter()
    {
        var value = Guid.NewGuid();
        new MyId(value).Value.Should().Be(value);
    }

    private sealed record MyId : EntityId
    {
        public MyId(Guid value) : base(value) { }
    }
}