using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Pokemon
    {
        public string Name;
        public int Level;
        public int Health;


        public Pokemon(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }

        public Pokemon(string name)
        {
            Name = name;
        }
    }
}
