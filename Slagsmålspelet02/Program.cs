using Slagsmålspelet02;

class Program
{
    static void Main()
    {
        try
        {
            // Skapa första kämpen och ge den ett vapen
            Fighter fighter = new Fighter
            {
                Name = "Hercules",
                Gun = new Weapon { Name = "Ak-47" }
            };

            // Skapa andra kämpen och ge den ett vapen
            Fighter fighter2 = new Fighter
            {
                Name = "Hades",
                Gun = new Weapon { Name = "Glock" }
            };

            // Skapa en superkämpe och ge den ett vapen
            SuperFighter superFighter = new SuperFighter
            {
                Name = "Zeus",
                Gun = new Weapon { Name = "M16" }
            };

            // Skapa ett inventarie och lägg till några vapen
            var inventory = new Inventory<Weapon>();
            inventory.AddItem(new Weapon { Name = "Sword" });
            inventory.AddItem(new Weapon { Name = "Shield" });

            Random generator = new Random();

            // Loop som fortsätter så länge alla kämpar har HP över 0
            while (fighter.Hp > 0 && fighter2.Hp > 0 && superFighter.Hp > 0)
            {
                Console.WriteLine("...........NY RUNDA...........");
                Console.WriteLine($"{fighter.Name}: {fighter.Hp}    ------   {fighter2.Name}: {fighter2.Hp}    ------   {superFighter.Name}: {superFighter.Hp}");

                // Första kämpen skjuter på andra kämpen
                fighter.Shoot(fighter2);

                // Om andra kämpen fortfarande har HP, skjuter den på superkämpen
                if (fighter2.Hp > 0)
                {
                    fighter2.Shoot(superFighter);
                }

                // Om superkämpen fortfarande har HP, skjuter den på första kämpen
                if (superFighter.Hp > 0)
                {
                    superFighter.Shoot(fighter);
                }

                Console.WriteLine("TRYCK PÅ EN KNAPP FÖR ATT FORTSÄTTA");
                Console.ReadKey();
            }

            Console.WriteLine("-----KRIGET ÄR ÖVER-----");

            // Kontrollera resultatet av striden
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
            // Hantera specifikt fel om pop på en tom stack försöks
            Console.WriteLine($"Fel: {e.Message}");
        }
        catch (Exception e)
        {
            // Hantera alla andra oväntade fel
            Console.WriteLine($"Ett oväntat fel uppstod: {e.Message}");
        }
    }
}
