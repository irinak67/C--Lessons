namespace Pattern_STRATEGY.Strategies;
internal class WaterGun : IWeapon
{
    void IWeapon.Shoot()
    {
        Console.WriteLine("attacks with a water gun");
    }
}
