namespace Pattern_PROTOTYPE;
class Sheep : IAnimal
{
    private string name;
    public Sheep() { }
    private Sheep(Sheep donor) => this.name = donor.name;
    IAnimal IAnimal.Clone() => new Sheep(this);

    string IAnimal.GetName() => name;    

    void IAnimal.SetName(string name) => this.name = name;
}
