namespace Records;

using Shouldly;
using Xunit;

public class Equality
{
    [Fact]
    public void Objects_ARE_PropertyEqual()
    {
        var alice1 = new NameRecord("Alice", "Apple");
        var alice2 = new NameRecord("Alice", "Apple");

        (alice1 == alice2).ShouldBeTrue();
    }

    [Fact]
    public void Objects_ARE_NOT_ReferenceEqual()
    {
        var alice1 = new NameRecord("Alice", "Apple");
        var alice2 = new NameRecord("Alice", "Apple");

        ReferenceEquals(alice1, alice2).ShouldBeFalse();
    }
}