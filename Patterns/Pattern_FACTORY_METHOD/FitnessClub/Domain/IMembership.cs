namespace Pattern_FACTORY_METHOD.FitnessClub.Domain;
internal interface IMembership
{
    string Name { get; }
    string Description { get; set; }
    decimal GetPrice();
}
