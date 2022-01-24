namespace Records;

using Xunit;
using Xunit.Abstractions;

public class Formatting
{
    private readonly ITestOutputHelper _output;
    public Formatting(ITestOutputHelper output) => _output = output;

    [Fact]
    public void HelpfulToString()
    {
        var aliceFromClass = new NameClass("Alice", "Apple");

        var aliceFromRecord = new NameRecord("Alice", "Apple");

        _output.WriteLine($"alice from class: {aliceFromClass}");
        _output.WriteLine("");
        _output.WriteLine($"alice from record: {aliceFromRecord}");
    }
}