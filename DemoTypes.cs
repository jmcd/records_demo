namespace Records;

// class interface struct enum tuples

public class NameClass
{
    public NameClass(string given, string family)
    {
        Given = given;
        Family = family;
    }

    public string Given { get; }
    public string Family { get; }
}

public record NameRecord(string Given, string Family);

// smaller
// property equality
// tostring
// deconstructor
// with
// cases