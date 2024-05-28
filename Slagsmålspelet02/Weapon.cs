using System;
using System.Collections.Generic;

namespace Slagsmålspelet02
{
    public class Weapon
    {
        public string Name { get; set; }

        private Random generator;

        public Weapon()
        {
            generator = new Random();
        }

        public int TakeDmg()
        {
            return generator.Next(10, 40);

        }
    }
}