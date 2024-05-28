using Slagsmålspelet02;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Fighter fighter = new Fighter
            {
                Name = "Hercules",
                Gun = new Weapon { Name = "Ak-47" }
            };

            Fighter fighter2 = new Fighter
            {
                Name = "Hades",
                Gun = new Weapon { Name = "Glock" }
            };

            SuperFighter superFighter = new SuperFighter
            {
                Name = "Zeus",
                Gun = new Weapon { Name = "M16" }

            };

            Random generator = new Random();

            while (fighter.Hp > 0 && fighter2.Hp > 0 && superFighter.Hp > 0)
            {
                Console.WriteLine("...........NY RUNDA...........");
                Console.WriteLine($"{fighter.Name}: {fighter.Hp}    ------   {fighter2.Name}: {fighter2.Hp}    ------   {superFighter.Name}: {superFighter.Hp}");

                fighter.Shoot(fighter2);
                if (fighter2.Hp > 0)
                {
                    fighter2.Shoot(superFighter);
                }
                if (superFighter.Hp > 0)
                {
                    superFighter.Shoot(fighter);
                }

                Console.WriteLine("TRYCK PÅ EN KNAPP FÖR ATT FORTSÄTTA");
                Console.ReadKey();
            }

            Console.WriteLine("-----KRIGET ÄR ÖVER-----");

            if (fighter.Hp == 0 && fighter2.Hp == 0 && superFighter.Hp == 0)
            {
                Console.WriteLine("---OAVGJORT---");
            }
            else if (fighter.Hp > 0)
            {
                Console.WriteLine($"{fighter.Name} -[VANN KRIGET]-");
            }
            else if (fighter2.Hp > 0)
            {
                Console.WriteLine($"{fighter2.Name} -[VANN KRIGET]-");
            }
            else if (superFighter.Hp > 0)
            {
                Console.WriteLine($"{superFighter.Name} -[VANN KRIGET]-");
            }

            Console.WriteLine("TRYCK PÅ EN KNAPP FÖR ATT AVSLUTA KRIGET");
            Console.ReadKey();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine($"Fel: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ett oväntat fel uppstod: {e.Message}");
        }
    }
}