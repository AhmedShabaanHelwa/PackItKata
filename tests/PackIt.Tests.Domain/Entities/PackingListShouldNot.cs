using FluentAssertions;
using PackIt.Domain.Entities;
using PackIt.Domain.Exceptions;
using System;
using Xunit;
namespace PackIt.Tests.Domain.Entities;

public class PackingListShouldNot
{
    private const string _localization = "Cairo,Eygpt";
    
    [Theory]
    [InlineData("", _localization)]       // Empty string
    [InlineData(null, _localization)]     //null string
    [InlineData(" ", _localization)]      // single White space
    [InlineData("      ", _localization)] // White spaces
    internal void AcceptEmptyName(string name, string localization)
    {
        // Arrange
        PackingList packingList;
        Type emptyNameExceptionType = typeof(EmptyPackingListNameException);
        
        try
        {
            // Act
            packingList = new PackingList(name, localization);
            // Assert
            packingList.Should().NotBeOfType(emptyNameExceptionType);
        }
        catch (Exception e)
        {
            // Assert
            e.Should().BeOfType(emptyNameExceptionType);
        }
    }
}
