namespace Riders.Domain.Core.UnitTests;

public sealed class EntityTests
{
    private readonly MyEntity _entity = new();

    [Fact]
    public void Id_Should_Be_Not_Null_When_Object_Created()
        => _entity.Id.Should().NotBeEmpty();

    [Fact]
    public void Generic_Equals_Should_Return_False_When_Different_Type()
        => _entity.Equals(new SecondType()).Should().BeFalse();

    [Fact]
    public void Generic_Equals_Should_Return_False_When_Same_Type_Different_Instance()
        => _entity.Equals((object)new MyEntity()).Should().BeFalse();

    [Fact]
    public void Generic_Equals_Should_Return_True_When_Same_Instance()
        => _entity.Equals((object)_entity).Should().BeTrue();

    [Fact]
    public void Generic_Equals_Should_Return_False_When_Null()
        => _entity.Equals((object?)null).Should().BeFalse();

    [Fact]
    public void Specialized_Equals_Should_Return_False_When_Same_Type_Different_Instance()
        => _entity.Equals(new MyEntity()).Should().BeFalse();

    [Fact]
    public void Specialized_Equals_Should_Return_True_When_Same_Instance()
        => _entity.Equals(_entity).Should().BeTrue();

    [Fact]
    public void Specialized_Equals_Should_Return_False_When_Null()
        => _entity.Equals(null).Should().BeFalse();

    [Fact]
    public void Operator_Equal_Should_Return_False_When_First_Is_Null()
        => (null == _entity).Should().BeFalse();

    [Fact]
    public void Operator_Equal_Should_Return_False_When_Second_Is_Null()
        => (_entity == null).Should().BeFalse();

    [Fact]
    public void Operator_Equal_Should_Return_True_When_Both_Null()
        => ((MyEntity?)null == null).Should().BeTrue();

    [Fact]
    public void Operator_Equal_Should_Return_False_When_Different_Identities()
        => (_entity == new MyEntity()).Should().BeFalse();

    [Fact]
    public void Operator_Equal_Should_Return_True_When_Same_Identities()
    {
        var anotherVariable = _entity;
        (_entity == anotherVariable).Should().BeTrue();
    }

    [Fact]
    public void Operator_Different_Should_Return_True_When_First_Is_Null()
        => (null != _entity).Should().BeTrue();

    [Fact]
    public void Operator_Different_Should_Return_True_When_Second_Is_Null()
        => (_entity != null).Should().BeTrue();

    [Fact]
    public void Operator_Different_Should_Return_False_When_Both_Null()
        => ((MyEntity?)null != null).Should().BeFalse();

    [Fact]
    public void Operator_Different_Should_Return_True_When_Different_Identities()
        => (_entity != new MyEntity()).Should().BeTrue();

    [Fact]
    public void Operator_Different_Should_Return_False_When_Same_Identities()
    {
        var anotherVariable = _entity;
        (_entity != anotherVariable).Should().BeFalse();
    }

    private sealed class MyEntity : Entity { }

    private sealed class SecondType { }
}