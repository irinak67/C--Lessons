using Pattern_STRATEGY;
using Pattern_STRATEGY.Strategies;

Hero hero = new Hero("Squidward");

hero.Attack();

hero.SetWeapon(new Broom());

hero.Attack();

hero.SetWeapon(new Planger());

hero.Attack();

Console.ReadLine();