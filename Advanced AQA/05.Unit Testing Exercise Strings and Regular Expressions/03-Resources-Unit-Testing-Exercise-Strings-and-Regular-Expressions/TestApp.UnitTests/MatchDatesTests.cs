using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string inputDates = "01-January-2023";

        // Act
        string result = MatchDates.Match(inputDates);

        // Assert
        Assert.That(result, Is.EqualTo("Day: 01, Month: January, Year: 2023"));
    }

    
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "Invalid date format";
        string expected = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "Date: 01-January-2023, Another date: 15-February-2023";
        string expected = "Day: 01, Month: January, Year: 2023";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string? input = null;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
    }
}
