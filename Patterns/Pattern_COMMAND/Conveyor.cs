namespace Pattern_COMMAND;

class Conveyor
{
    public void On() => Console.WriteLine("Conveyor is started");
    public void Off() => Console.WriteLine("Conveyor is stopped");
    public void SpeedIncrease() => Console.WriteLine("Speed is increased");
    public void SpeedDecrease() => Console.WriteLine("Speed is decreased");
}
