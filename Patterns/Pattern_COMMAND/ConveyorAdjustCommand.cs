namespace Pattern_COMMAND;

class ConveyorAdjustCommand : ICommand
{
    private Conveyor conveyor;
    public ConveyorAdjustCommand(Conveyor conveyor) => this.conveyor = conveyor;

    void ICommand.Negative() => conveyor.SpeedDecrease() ;

    void ICommand.Positive() => conveyor.SpeedIncrease();
}
