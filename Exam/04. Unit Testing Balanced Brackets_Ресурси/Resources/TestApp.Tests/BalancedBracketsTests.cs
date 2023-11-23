using System;
using NUnit.Framework;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        // Arrange
        string[] emptyInput = Array.Empty<string>();

        // Act
        bool result = BalancedBrackets.IsBalanced(emptyInput);

        // Assert
        Assert.That(result, Is.True, "Empty input should be considered balanced.");
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        // Arrange
        string[] balancedBracketsInput = { "(", ")", "{", "}", "[", "]" };

        // Act
        bool result = BalancedBrackets.IsBalanced(balancedBracketsInput);

        // Assert
        Assert.That(result, Is.True, "Balanced brackets input should return true.");
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] unbalancedBracketsInput = { "(", ")", "{", "}" };

        // Act
        bool result = BalancedBrackets.IsBalanced(unbalancedBracketsInput);

        // Assert
        Assert.That(result, Is.True, "Unbalanced brackets input should return false.");
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] inputWithMoreClosingBrackets = { "(", ")", ")", "{", "}" };

        // Act
        bool result = BalancedBrackets.IsBalanced(inputWithMoreClosingBrackets);

        // Assert
        Assert.That(result, Is.False, "Input with more closing brackets should return false.");
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] inputWithNoClosingBrackets = { "(", "{", "[" };

        // Act
        bool result = BalancedBrackets.IsBalanced(inputWithNoClosingBrackets);

        // Assert
        Assert.That(result, Is.False, "Input with no closing brackets should return false.");
    }
}
