namespace Records;

using Shouldly;
using Xunit;

public class NonDestructiveMutation
{
    [Fact]
    public void With()
    {
        var alice = new NameRecord("Alice", "Apple");

        var marriedAlice = alice with { Family = "Apple-Banana" };

        alice.Family.ShouldBe("Apple");
        marriedAlice.Family.ShouldBe("Apple-Banana");
    }
}