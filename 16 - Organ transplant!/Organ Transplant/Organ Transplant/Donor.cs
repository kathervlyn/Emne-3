using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organ_Transplant
{
    internal class Donor
    {
        public string Navn { get; }

        public Donor(string navn)
        {
            Navn = navn;
        }

        public bool KanGiNyren()
        {
            Console.WriteLine($"{Navn} gjennomgår tester for å avgjøre om han kan gi en nyre...");
            return true;
        }

        public void GiNyrenTil(Patient pasient)
        {
            Console.WriteLine($"{Navn} gir en nyre til {pasient.Navn}.");
        }
    }
}
