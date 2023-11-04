namespace D03cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat de gebruiker om de straal van een cirkel (een kommagetal!) vraagt
            // en vervolgens zowel de omtrek als de oppervlakte van de cirkel toont.
            // Voor een cirkel geldt
            // de omtrek is 2 keer Pi keer de straal
            // de oppervlakte is Pi maal het kwadraat van de straal

            //vraag de gebruiker om de straal van de cirkel in te voeren
            Console.WriteLine("Geef de straal van de cirkel in: ");
            double straal = Convert.ToDouble(Console.ReadLine());

            // Bereken de omtrek en oppervlakte van de cirkel
            double omtrek = 2 * Math.PI * straal;
            double oppervlakte = Math.PI * Math.Pow(straal, 2);

            // Rond de getallen af op 2 cijfers na de komma
            double omtrek2 = Math.Round(omtrek, 2);
            double oppervlakte2 = Math.Round(oppervlakte, 2);

            // Toon de resultaten
            Console.WriteLine($"De omtrek van de cirkel is: {omtrek2}.");
            Console.WriteLine($"De oppervlakte van de cirkel is: {oppervlakte2}.");

        }
    }
}