using FluentAssertions;
using PackIt.Domain.ValueObjects;
using Xunit;

namespace PackIt.Tests.Domain.ObjectValues
{
    public class PackingListNameShould
    {
        [Fact]
        internal void ImplicitlyConvertFromStringToPackingListName()
        {
            // Arrange
            string stringfiedName = "Ahmed";
            // Act
            var valueObjectName = (PackingListName)stringfiedName;
            // Assert
            valueObjectName.Should().BeOfType(typeof(PackingListName));
            valueObjectName.Value.Should().Be("Ahmed");
        }

        [Fact]
        internal void ImplicitlyConvertFromPackingListNameToString()
        {
            // Arrange
            PackingListName objectValueName = new("Ahmed");
            // Act
            var stringfiedName = (string)objectValueName;
            // Assert
            stringfiedName.Should().BeOfType(typeof(string));
            stringfiedName.Should().Be("Ahmed");
        }
    }
}
