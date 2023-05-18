using SafariGameApp;
namespace SafariGameTests;

public class PlayerInteractionTests
{
    //given a player input
    //when it matches a valid command
    //then the game logic responds
    GameLogic gameLogic;

    [SetUp]
    public void SetUp()
    {
        gameLogic = new("Groucho", "Marx");
    }

    [Test]
    public void WhenPlayerInputsB_TheyMoveBack()
    {
        string inputString = "B";
        int expectedPosition = gameLogic.PlayerPosition - gameLogic.PlayerSpeed;
        gameLogic.ProcessPlayerInput(inputString);
        int newPosition = gameLogic.PlayerPosition;
        Assert.That(newPosition, Is.EqualTo(expectedPosition));
    }

    [Test]
    public void WhenPlayerInputsF_TheyMoveForward()
    {
        string inputString = "F";
        int expectedPosition = gameLogic.PlayerPosition + gameLogic.PlayerSpeed;
        gameLogic.ProcessPlayerInput(inputString);
        int newPosition = gameLogic.PlayerPosition;
        Assert.That(newPosition, Is.EqualTo(expectedPosition));
    }

    //WhenPlayerInputsS_TheyShoot();

    [Test]

    public void WhenPlayerInputsInvalidCommand_TheyArePromptedToTryAgain()
    {
        string invalidInputString = "ff";
        bool inputValid = gameLogic.ProcessPlayerInput(invalidInputString);

        Assert.That(inputValid, Is.False);

    }
}
