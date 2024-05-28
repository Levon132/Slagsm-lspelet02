public class SuperFighter : Fighter
{
    // Egenskap för att lagra rustningsvärdet, endast åtkomligt inom denna klass
    public int Armor { get; private set; }

    // Konstruktor för klassen SuperFighter, som anropar basklassen Fighter's konstruktor
    public SuperFighter() : base()
    {
        // Initierar Armor-egenskapen med värdet 20
        Armor = 20;
    }

    // Överskuggar Shoot-metoden från klassen Fighter för att lägga till ytterligare funktionalitet
    public override void Shoot(Fighter target)
    {
        // Anropar Shoot-metoden från basklassen Fighter för att utföra grundläggande skjutbeteende
        base.Shoot(target);
        
        Hp = Math.Min(100, Hp + 5);  // SuperFighter regenererar 5 HP varje gång den skjuter
        
        // Skriver ut det nya HP-värdet till konsolen
        Console.WriteLine($"{Name} regenererar 5 HP och har nu {Hp} HP.");
    }
}
