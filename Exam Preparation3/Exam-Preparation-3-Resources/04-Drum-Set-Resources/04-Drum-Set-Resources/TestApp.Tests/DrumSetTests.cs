using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int> { 10, 20, 30 };
        List<string> commands = new List<string> { "10", "20" };

        //Act & Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int> { 10, 20, 30 };
        List<string> commands = new List<string> { "10", "20", "InvalidCommand", "Hit it again, Gabsy!" };

        //Act & Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 10;
        List<int> initialQuality = new List<int> { 10, 20 };
        List<string> commands = new List<string> { "10", "Hit it again, Gabsy!" };

        string expectedResult = "10\nGabsy has 10.00lv.";
        string result = DrumSet.Drum(money, initialQuality, commands);

        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_Drum_RemoveDrum_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 100;
        List<int> initialQuality = new List<int> { 10, 20 };
        List<string> commands = new List<string> { "10", "Hit it again, Gabsy!" };

        string expectedResult = "10 10\nGabsy has 70.00lv.";
        string result = DrumSet.Drum(money, initialQuality, commands);

        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 0;
        List<int> initialQuality = new List<int> { 10, 20 };
        List<string> commands = new List<string> { "10", "Hit it again, Gabsy!" };

        string expectedResult = "10\nGabsy has 0.00lv.";
        string result = DrumSet.Drum(money, initialQuality, commands);

        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 5;
        List<int> initialQuality = new List<int> { 5, 2 };
        List<string> commands = new List<string> { "5", "Hit it again, Gabsy!" };

        string expectedResult = "\nGabsy has 5.00lv.";
        string result = DrumSet.Drum(money, initialQuality, commands);

        CollectionAssert.AreEqual(expectedResult, result);
    }
}
