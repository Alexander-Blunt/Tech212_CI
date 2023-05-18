using SafariGameApp;
namespace InputHandlerTests;

public class Tests
{
    Input input;

    [SetUp]
    public void Setup()
    {
        input = new();
    }

    [TestCase("F", InputCommand.FORWARD)]
    [TestCase("B", InputCommand.BACK)]
    [TestCase("S", InputCommand.SHOOT)]
    public void GivenInputString_Handle_ReturnsCommand(string inputString, InputCommand expectedCommand)
    {
        InputCommand command = input.Handle(inputString);
        Assert.That(command, Is.EqualTo(expectedCommand));
    }

    [Test]
    public void GivenIncorrectInput_Handle_ReturnsInvalid()
    {
        string inputString = "gkkk";
        InputCommand expectedCommand = InputCommand.INVALID;

        InputCommand result = input.Handle(inputString);

        Assert.That(result, Is.EqualTo(expectedCommand));
    }
}