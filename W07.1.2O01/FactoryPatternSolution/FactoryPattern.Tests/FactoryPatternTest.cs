namespace FactoryPattern.Tests;

[TestClass]
public class FactoryPatternTest
{
    [TestMethod]
    public void CreateLightTheme_Document()
    {
        // Arrange
        var factory = new DocumentFactory();

        // Act
        Document document = factory.CreateLightTheme();

        // Assert
        Assert.AreEqual("White", document.BackGroundColor);
        Assert.AreEqual("Black", document.FontColor);
    }

    [TestMethod]
    public void CreateDarkTheme_Document()
    {
        // Arrange
        var factory = new DocumentFactory();

        // Act
        Document document = factory.CreateDarkTheme();

        // Assert
        Assert.AreEqual("Black", document.BackGroundColor);
        Assert.AreEqual("White", document.FontColor);
    }

    [TestMethod]
    public void CreateLightTheme_IDE()
    {
        // Arrange
        var factory = new IDEFactory();

        // Act
        IDE ide = factory.CreateLightTheme();

        // Assert
        Assert.AreEqual("White", ide.BackGroundColor);
        Assert.AreEqual("Black", ide.FontColor);
        Assert.AreEqual("Light blue", ide.ButtonColor);
    }

    [TestMethod]
    public void CreateDarkTheme_IDE()
    {
        // Arrange
        var factory = new IDEFactory();

        // Act
        IDE ide = factory.CreateDarkTheme();

        // Assert
        Assert.AreEqual("Black", ide.BackGroundColor);
        Assert.AreEqual("White", ide.FontColor);
        Assert.AreEqual("Light yellow", ide.ButtonColor);
    }
}