using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Person
    {
        public string Name;
        public int Age;
        public string Address;


        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age, string adress)
        {
            Name = name;
            Age = age;
            Address = adress;
        }

        public void PrintWelcomeMessage(string velkommenMelding)
        {
            Console.WriteLine(velkommenMelding + Name);
        }

    }
}
