namespace Organ_Transplant
{
    internal class Program
    {
        static void Main()
        {
           Patient bernt = new Patient("Bernt");
            Donor kaare = new Donor("Kåre");
            bool kanGiNyren = kaare.KanGiNyren();

            if (kanGiNyren)
            {
                kaare.GiNyrenTil(bernt);
                Console.WriteLine($"{kaare.Navn} har donert en nyre til {bernt.Navn}. Transplantasjonen vellykket!");
                bernt.SjekkTilstand();
            }
            else
            {
                Console.WriteLine($"{kaare.Navn} kan dessverre ikke gi en nyre til {bernt.Navn}.");
            }
        }
    }
}
//    Oppgave: Organ transplant!
//
//    Det har vært en akutt ulykke og Bernt ligger på sykehuset.
//    Han trenger en ny Nyre!
//    Heldigvis har fetteren hans Kåre to sunne Nyrer,
//    og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!
//    Hjelp Bernt med å overleve!
//    Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.
//    Lag gjerne Consoll.WriteLine() -statements i koden slik at man ser hva som skjer!