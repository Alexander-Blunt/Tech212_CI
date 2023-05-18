using SafariGameApp;
namespace HighscoreOutputTests;

public class Tests
{
    HighScoreObject highScore1, highScore2, highScore3;

    [SetUp]
    public void Setup()
    {
        highScore1 = new("Itchy", 200, "30/3/2022");
        highScore2 = new("Scratchy", 300, "20/3/2022");
        highScore3 = new("Poochy", 250, "30/3/2022");
    }

    [Test]
    public void Sort_GivenThreeScoreObjects_SortsByScore()
    {
        List<HighScoreObject> highScoreList = new();
        highScoreList.Add(highScore1);
        highScoreList.Add(highScore2);
        highScoreList.Add(highScore3);
        highScoreList.Sort();

        Assert.That(highScoreList[0], Is.EqualTo(highScore2));
    }
}