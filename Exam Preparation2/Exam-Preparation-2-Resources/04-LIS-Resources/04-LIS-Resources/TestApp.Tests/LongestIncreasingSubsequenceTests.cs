using NUnit.Framework;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        //Arrange
        int[] array = null;

        //Act & Assert
        Assert.That(() => LongestIncreasingSubsequence.GetLis(array), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = LongestIncreasingSubsequence.GetLis(emptyArray);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        //Arrange
        int[] singleElementArray = new int[] { 1 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(singleElementArray);

        //Assert
        CollectionAssert.AreEqual("1", result);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        //Arrange
        int[] array = new int[] { 1, 2, 5, 4, 3, 1 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        //Assert
        CollectionAssert.AreEqual("1 2 5", result);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        //Arrange
        int[] array = new int[] { 1, 2, 5, 7, 9, 15 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        //Assert
        CollectionAssert.AreEqual("1 2 5 7 9 15", result);
    }
}
