using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 1;
        double x2 = 2;
        double y2 = 2;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        CollectionAssert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 2;
        double y1 = 2;
        double x2 = 1;
        double y2 = 1;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        CollectionAssert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 1.5;
        double y1 = 1.5;
        double x2 = 1.5;
        double y2 = 1.5;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        CollectionAssert.AreEqual("(1.5, 1.5)", result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = -1;
        double y1 = -1;
        double x2 = 10;
        double y2 = 10;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        CollectionAssert.AreEqual("(-1, -1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 1;
        double x2 = -1;
        double y2 = -1;

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert        
        CollectionAssert.AreEqual("(-1, -1)", result);
    }
}
