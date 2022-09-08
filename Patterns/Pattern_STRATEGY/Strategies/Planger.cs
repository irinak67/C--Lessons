namespace Pattern_STRATEGY.Strategies;

internal class Planger : IWeapon
{
    void IWeapon.Shoot()
    {
        Console.WriteLine("attacks with a planger");
    }
}
