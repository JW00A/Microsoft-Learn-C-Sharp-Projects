int heroVitality = 10;
int monsterHP = 10;

Random rollDamage = new Random();

while (heroVitality > 0 && monsterHP > 0)
{
    int heroAttack = rollDamage.Next(1, 10);

    monsterHP -= heroAttack;

    if (monsterHP <= 0) 
    {
        Console.WriteLine($"Hero attacked the ogre with {heroAttack} damage points.");
        Console.WriteLine("Hero wins!");
        break;
    }
    else
    {
        Console.WriteLine($"Ogre lost {heroAttack} hp and now has {monsterHP} hp.");
    }

    int monsterAttack = rollDamage.Next(1, 10);

    heroVitality -= monsterAttack;

    if (heroVitality <= 0)
    {
        Console.WriteLine($"Ogre attacked the hero with {monsterAttack} damage points.");
        Console.WriteLine("Ogre wins!");
        break;
    }
    else
    {
        Console.WriteLine($"Hero lost {monsterAttack} hp and now has {heroVitality} hp.");
    }
}
