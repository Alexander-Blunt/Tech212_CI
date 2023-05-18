namespace SafariGameApp;

public class Input
{
    private Dictionary<string, InputCommand> _commandsDict;
    
    public Input()
    {
        _commandsDict = new()
        {
            {"F", InputCommand.FORWARD},
            {"B", InputCommand.BACK },
            {"S", InputCommand.SHOOT }
            //{"?", InputCommand.HELP },
            //{"HELP", InputCommand.HELP }
        };
    }

    public InputCommand Handle(string inputString)
    {
        string str = inputString.ToUpper();
        foreach(string key in _commandsDict.Keys)
        {
            if(str == key)
            {
                return _commandsDict[str];
            }
        }
        return InputCommand.INVALID;
    }

    public string Receive()
    {
        string playerInput = "";
        while (playerInput is null || playerInput == "")
        {
            playerInput = Console.ReadLine();
        }
        return playerInput;
    }
}
public enum InputCommand
{
    FORWARD, BACK, SHOOT, INVALID
}
