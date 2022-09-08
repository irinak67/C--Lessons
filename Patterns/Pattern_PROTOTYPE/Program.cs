using Pattern_PROTOTYPE;

IAnimal sheepDonor = new Sheep();
sheepDonor.SetName("Dolly");

IAnimal sheepClone = sheepDonor.Clone();

Console.WriteLine(sheepDonor.GetName());
Console.WriteLine(sheepClone.GetName());
