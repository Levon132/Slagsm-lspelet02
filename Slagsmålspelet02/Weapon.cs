namespace Slagsmålspelet02
{
    public class Weapon
    {
        // Egenskap som representerar vapnets namn
        public string Name { get; set; }

        // Privat generator för att skapa slumpmässiga tal
        private Random generator;

        // Konstruktor som initialiserar slumpgeneratorn
        public Weapon()
        {
            generator = new Random();
        }

        // Metod för att generera slumpmässig skada
        public int TakeDmg()
        {
            // Genererar ett slumpmässigt tal mellan 10 och 40 (inklusive)
            return generator.Next(10, 40);
        }
    }
}
