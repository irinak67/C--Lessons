namespace Pattern_STRATEGY.Strategies;

internal class Broom : IWeapon
{
    void IWeapon.Shoot()
    {
        Console.WriteLine("attacks with a broom");
    }
}
