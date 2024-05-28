public class SuperFighter : Fighter
{
    public int Armor { get; private set; }

    public SuperFighter() : base()
    {
        Armor = 20;
    }

    public override void Shoot(Fighter target)
    {
        base.Shoot(target);
        Hp = Math.Min(100, Hp + 5);  // SuperFighter regenererar 5 HP varje gång den skjuter
        Console.WriteLine($"{Name} regenererar 5 HP och har nu {Hp} HP.");
    }
}