using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }
    
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> list = new List<int> { 42 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new List<int> { 7, 7, 7 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new List<int> { 6, 6, 3 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 10, 20 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new List<int> { 21, 12, 8, 4 };
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 14, 15 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> expected = new List<int> { 16, 16, 3 };
        CollectionAssert.AreEqual(expected, result);
    }
}
