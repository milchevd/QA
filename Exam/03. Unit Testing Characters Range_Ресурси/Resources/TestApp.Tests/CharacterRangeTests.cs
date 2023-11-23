using NUnit.Framework;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        //Arrange
        char a = 'A';
        char b = 'B';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.IsEmpty(result, "When characters are in order, the result should be an empty string.");
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        //Arrange
        char a = 'B';
        char b = 'A';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.IsEmpty(result, "When characters are in order, the result should be an empty string.");
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char a = 'A';
        char c = 'C';

        // Act
        string result = CharacterRange.GetRange(a, c);

        // Assert
        CollectionAssert.AreEqual("B", result, "When characters are in order A, B, C, the result should be 'B'.");
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char d = 'D';
        char g = 'G';

        // Act
        string result = CharacterRange.GetRange(d, g);

        // Assert
        CollectionAssert.AreEqual("E F", result, "When characters are in order D, E, F, G, the result should be 'E F'.");
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char x = 'X';
        char z = 'Z';

        // Act
        string result = CharacterRange.GetRange(x, z);

        // Assert
        CollectionAssert.AreEqual("Y", result, "When characters are in order X, Y, Z, the result should be 'Y'.");
    }
}
