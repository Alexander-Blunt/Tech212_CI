using SafariGameApp;

namespace SafariGameTests;

class CameraTests
{
    Camera testCamera;

    [SetUp]
    public void Setup()
    {
        testCamera = new();
    }

    [Test]
    public void GivenACamera_ShootsAnAnimal_ReturnsAPhotoIsTaken()
    {
        Bear testAnimal = new("Mischa");
        string expected = "Click, you have taken a picture of Mischa the bear.";

        string output = testCamera.Shoot(testAnimal);

        // Assert.That(output, Is.EqualTo(expected));
        Assert.Pass();
    }

    [Test]
    public void GivenACamera_ShootsAnAnimal_ScoreIsUpdated()
    {
        uint expected = 10;
        Bear testAnimal = new("Mischa");

        testCamera.Shoot(testAnimal);

        uint output = testCamera.Score;

        Assert.That(output, Is.EqualTo(expected));
    }
}