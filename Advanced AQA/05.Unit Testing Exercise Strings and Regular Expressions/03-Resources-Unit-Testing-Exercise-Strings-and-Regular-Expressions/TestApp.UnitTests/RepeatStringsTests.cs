using NuGet.Frameworks;
using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = { "1" };
        string expected = "1";

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = { "abc", "def", "123" };
        string expected = "abcabcabcdefdefdef123123123";

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
