using PackIt.Domain.Exceptions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PackIt.Tests.Domain")]
namespace PackIt.Domain.ValueObjects;

/// <summary>
/// List name value object.
/// </summary>
public record PackingListName
{
    public string Value;
    public PackingListName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new EmptyPackingListNameException();
        
        Value = value;
    }

    /// <summary>
    /// Implicit conversion from string to PackingListName.
    /// </summary>
    /// <param name="name">Name of the packing list</param>
    public static implicit operator PackingListName(string name) => new PackingListName(name);
    /// <summary>
    /// Implicit conversion from PackingListName to string.
    /// </summary>
    /// <param name="name"></param>
    public static implicit operator string(PackingListName name) => name.Value;
}