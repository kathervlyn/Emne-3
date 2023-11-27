using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekter_som_i_JavaScript
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
    }
}
