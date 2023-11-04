namespace D04groterofgelijk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat de gebruiker om twee getallen vraagt
            // en naargelang de situatie "het eerste is groter", "het tweede is groter" en "ze zijn gelijk" afbeeldt.

            Console.WriteLine("Geef 1ste getal: ");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef 2de getal: ");
            int getal2 = int.Parse(Console.ReadLine());

            if (getal1 > getal2)
            {
                Console.WriteLine("Het eerste getal is groter.");
            }
            else if (getal2 > getal1)

                    Console.WriteLine("Het tweede getal is groter");
                
                else if (getal1 == getal2)
                {
                    Console.WriteLine("De 2 getallen zijn gelijk.");

            }
        }
    }
}