using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organ_Transplant
{
    internal class Patient
    {
        public string Navn { get; }

        public Patient(string navn)
        {
            Navn = navn;
        }

        public void SjekkTilstand()
        {
            Console.WriteLine($"{Navn} er nå i bedre tilstand etter transplantasjonen.");
        }
    }
}
