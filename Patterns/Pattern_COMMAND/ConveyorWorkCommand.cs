namespace Pattern_COMMAND;

class ConveyorWorkCommand : ICommand
{
    private Conveyor conveyor;
    public ConveyorWorkCommand(Conveyor conveyor) => this.conveyor = conveyor;

    void ICommand.Negative() => conveyor.Off();

    void ICommand.Positive() => conveyor.On();
}
