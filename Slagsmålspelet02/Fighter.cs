using Slagsmålspelet02;

public class Fighter
{
    public int Hp { get; protected set; }
    public string Name { get; set; }
    public Weapon Gun { get; set; }

    public Fighter()
    {
        Hp = 100;
    }

    public virtual void Shoot(Fighter target)
    {
        if (Gun == null)
        {
            Console.WriteLine($"{Name} har inget vapen att skjuta med!");
            return;
        }

        int blood = Gun.TakeDmg();
        target.Hp -= blood;
        target.Hp = Math.Max(0, target.Hp);
        Console.WriteLine($"{Name} gör {blood} skada på {target.Name}");
    }
}
