namespace SafariGameApp;

public class Program
{
    static void Main(string[] args)
    {
        GameIntro();
        string[] playerNames = EnterPlayer();
        Console.WriteLine("Press F to move forwards, B to move backwards, S to take a picture. Good luck.");
        GameLogic gameLogic = new GameLogic(playerNames[0], playerNames[1]);

        gameLogic.GameLoop();
    }

    static void GameIntro()
    {
        Console.WriteLine("Welcome to the Safari!");
        Console.WriteLine(" ");
        Console.WriteLine("Here are the rules to the game:");
        Console.WriteLine(" ");
        Console.WriteLine("You, a hunter, will set out on a Safari Trail");
        Console.WriteLine("During your trail you will encounter many different animals.");
        Console.WriteLine("Your job is to take pictures of them to collect points.");
        Console.WriteLine("The more dangerous an animal, the higher your score");
        Console.WriteLine("Be weary, get too close and you might die and the game will end!!!");
        Console.WriteLine(" ");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.Clear();
    }

    static string[] EnterPlayer()
    {
        string[] output = new string[2];

        Console.WriteLine("Please enter your first name to begin ... ");
        output[0] = Console.ReadLine();
        Console.WriteLine("Now enter your last name ... ");
        output[1] = Console.ReadLine();
        return (output);
    }
}