namespace Records;

using Shouldly;
using Xunit;

public class Deconstructor
{
    [Fact]
    public void HasDeconstructor()
    {
        var alice = new NameRecord("Alice", "Apple");

        var (givenName, familyName) = alice;

        givenName.ShouldBe("Alice");
        familyName.ShouldBe("Apple");
    }
}