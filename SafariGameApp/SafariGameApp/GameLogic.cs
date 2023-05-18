namespace SafariGameApp;

public class GameLogic
{
    Input _playerInput;
    Hunter _player;
    Camera _camera;
    Animal _animal;
    bool _roundOver;

    public int PlayerPosition { get; set; }
    public int PlayerSpeed { get; }

    public GameLogic(string fName, string lName)
    {
        _camera = new();
        _playerInput = new Input();
        _player = new Hunter(fName, lName, _camera);
        PlayerPosition = _player.Position;
        PlayerSpeed = _player.Speed;
        _animal = new Cat("cat");
        _roundOver = false;
    }

    //returns true if input is valid
    public bool ProcessPlayerInput(string inputString)
    {
        if (inputString is null)
        {
            return false;
        }
        InputCommand playerCommand = _playerInput.Handle(inputString);

        switch (playerCommand)
        {
            case InputCommand.FORWARD:
                Console.WriteLine(_player.Move());
                PlayerPosition = _player.Position;
                break;
            case InputCommand.BACK:
                Console.WriteLine(_player.Back());
                break;
            case InputCommand.SHOOT:
                Console.WriteLine(_player.Shoot(_animal)); 
                _roundOver = true;
                break;
            case InputCommand.INVALID:
                return false;
            default:
                break;
        }

        return true;
    }

    public void GameLoop()
    {
        while (!_roundOver)
        {
            Console.WriteLine("Enter your command:");
            string playerInputString = Console.ReadLine();
            Console.Clear();
            while (!ProcessPlayerInput(playerInputString))
            {
                Console.WriteLine(
                    "That is not a valid command. Please choose one of the following: \n" +
                    "F to move Forward. B to move Backward. S to Shoot with your camera.");
                playerInputString = Console.ReadLine();
            }
        }
        EndGame();
    }
    public void EndGame()
    {
        Console.WriteLine(
            $"You scored {_camera.Score}.\n" +
            $"Thank you for playing!\n" +
            $"Press Enter to quit\n"
            );
        Console.ReadLine();
    }

}
