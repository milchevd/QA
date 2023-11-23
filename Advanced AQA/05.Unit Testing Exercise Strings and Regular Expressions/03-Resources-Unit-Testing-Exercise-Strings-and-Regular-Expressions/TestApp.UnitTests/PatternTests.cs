using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("abc", 3, "aBcaBcaBc")]
    [TestCase("xyz", 2, "xYzxYz")]
    [TestCase("123", 10, "123123123123123123123123123123")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 2;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abc";
        int negativeRepetitionFactor = -1;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, negativeRepetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {

        // Arrange
        string input = "abc";
        int zeroRepetitionFactor = 0;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, zeroRepetitionFactor));
    }
}
