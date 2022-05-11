using FluentAssertions;
using PackIt.Domain.Exceptions;
using PackIt.Domain.ValueObjects;
using System;
using Xunit;

namespace PackIt.Tests.Domain.ObjectValues;

public class PackingListNameShouldNot
{
    [Theory]
    [InlineData("")]        // Empty string
    [InlineData(null)]      //null string
    [InlineData(" ")]       // single White space
    [InlineData("      ")]  // White spaces
    internal void AcceptEmptyString(string stringValue)
    {
        try
        {
            // Act
            PackingListName? packingListName =  new PackingListName(stringValue);
            packingListName.Should().NotBeOfType(typeof(PackingListName));
        }
        catch (Exception exption)
        {
            exption.Should().BeOfType(typeof(EmptyPackingListNameException));
        }
    }
}
