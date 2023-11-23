using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        //Arrange
        string path = null;

        //Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        //Arrange
        string path = "";

        //Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"C:\path\to\file.txt";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        CollectionAssert.AreEqual("File name: file\nFile extension: txt", result);
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = @"C:\path\to\file";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        CollectionAssert.AreEqual("File name: file", result);
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"C:\path\to\file with$special!characters.txt";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        CollectionAssert.AreEqual("File name: file with$special!characters\nFile extension: txt", result);
    }
}
