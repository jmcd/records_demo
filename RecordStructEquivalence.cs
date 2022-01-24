namespace Records;

using Shouldly;
using Xunit;

public class RecordStructEquivalence
{
    private record struct NameStruct(string Given, string Family);

    [Fact]
    public void RecordsCanBeStructs()
    {
        typeof(NameStruct).StructLayoutAttribute?.ShouldNotBeNull();

        var alice = new NameStruct("Alice", "Apple");

        MyReferenceEquals(alice, alice).ShouldBeFalse();
    }

    private bool MyReferenceEquals<T>(T nameA, T nameB) => ReferenceEquals(nameA, nameB);

}