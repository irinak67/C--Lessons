using Pattern_COMMAND;

Conveyor conveyor = new Conveyor();
Multipult multipult = new Multipult();

multipult.SetCommand(0, new ConveyorWorkCommand(conveyor));
multipult.SetCommand(1, new ConveyorAdjustCommand(conveyor));

multipult.Presson(0);
multipult.Presson(1);

multipult.PressCancel();
multipult.PressCancel();
