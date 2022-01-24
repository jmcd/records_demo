namespace Records;

using Shouldly;
using Xunit;

public class RecordClassEquivalence
{
    [Fact]
    public void RecordsAreClasses()
    {
        typeof(NameRecord).IsClass.ShouldBeTrue();
    }
}