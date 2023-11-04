namespace WhileGrootsteKleinste
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vraag B:
            // Lees een aantal gehele getallen in,
            // sluit af met 0 (wordt  niet  meer  verwerkt).
            // Vervolgens wordt het kleinste en het grootste getal weergegeven.
            // Indien de gebruiker onmiddellijk nul ingeeft,
            // moet er een foutboodschap verschijnen.

            int min = int.MaxValue, max = int.MinValue, input;
            int teller = 0;

            Console.WriteLine("Voer gehele getallen in. Voer s in om te stoppen.");

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out input))
                    {
                        if (input == 's')
                            break;

                        min = Math.Min(min, input);
                        max = Math.Max(max, input);
                    }
                    else
                    {
                        Console.WriteLine("Er werden geen geldige getallen ingevoerd! ");
                    }
                }

                if (min != int.MaxValue)
                {
                    Console.WriteLine($"Het kleinste getal is: {min}");
                    Console.WriteLine($"Het grootste getal is: {max}");
                }

                teller++;
            
        }
    }
}