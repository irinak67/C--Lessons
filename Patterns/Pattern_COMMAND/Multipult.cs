namespace Pattern_COMMAND;
class Multipult 
{
    private List<ICommand> commands;
    private Stack<ICommand> history;

    public Multipult()
    {
        commands = new List<ICommand>() { null, null};
        history = new Stack<ICommand>();
    }

    public void SetCommand(int button, ICommand command) => commands[button] = command;
    public void Presson(int button)
    {
        commands[button].Positive();
        history.Push(commands[button]);
    }

    public void PressCancel()
    {
        if (history.Count != 0)
            history.Pop().Negative();
    }
    

}
