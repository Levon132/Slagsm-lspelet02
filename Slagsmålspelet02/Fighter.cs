using Slagsmålspelet02;

public class Fighter
{
    // HP (hälsa) för kämpen, kan bara sättas inom klassen eller av ärvande klasser
    public int Hp { get; protected set; }

    // Namn på kämpen
    public string Name { get; set; }

    // Kämpens vapen
    public Weapon Gun { get; set; }

    // Konstruktor som initierar kämpens HP till 100
    public Fighter()
    {
        Hp = 100;
    }

    // Metod för att kämpen ska skjuta på en annan kämpe
    public virtual void Shoot(Fighter target)
    {
        // Kontrollera om kämpen har ett vapen
        if (Gun == null)
        {
            Console.WriteLine($"{Name} har inget vapen att skjuta med!");
            return;
        }

        // Beräkna skadan och minska målets HP
        int blood = Gun.TakeDmg();
        target.Hp -= blood;
        target.Hp = Math.Max(0, target.Hp); // Se till att HP inte går under 0
        Console.WriteLine($"{Name} gör {blood} skada på {target.Name}");
    }
}
