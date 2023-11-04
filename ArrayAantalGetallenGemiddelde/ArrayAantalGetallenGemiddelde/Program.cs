using static System.Formats.Asn1.AsnWriter;

namespace ArrayAantalGetallenGemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int aantal = 0;
            int score = 0;
            int som = 0;

            // Vraag de gebruik om het aantal getallen in te geven 
            // dat hij zou willen verwerken.
            // Hou rekening met verkeerde input van de gebruiker. Zo moet
            // het getal strikt positief zijn (> 0) want een array dient een 
            // positieve grootte te hebben.
            do
            {
                Console.Write("Geef het aantal personen dat je wilt ingeven: ");
                try
                {
                    aantal = int.Parse(Console.ReadLine());
                    if (aantal <= 0)
                    {
                        Console.WriteLine("ongeldige ingave probeer opnieuw");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("ongeldige ingave probeer opnieuw");
                    continue;
                }
                break;
            } while (true);

            // Geef elk getal tussen [0;20] in en hou dit
            // bij om later te verwerken.
            // Hou rekening met verkeerde input!
            int[] scores = new int[aantal];

            for (i = 0; i < scores.Length; i++)
            {
                Console.Write($"Geef getal van [0:20] - {i + 1}: ");
                try
                {
                    score = int.Parse(Console.ReadLine());

                    if (score > 20 && score < 0)
                    {
                        Console.WriteLine("ongeldige ingave probeer opnieuw");
                        i--;
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("ongeldige ingave probeer opnieuw");
                    i--;
                    continue;
                }
                scores[i] = score;
            }

            // Print een histogram af op basis van deze getallen.
            // Distributie:
            // 0: ***
            // 1: *******
            // 2: ***
            // ...
            // 19: *****
            // 20: **
            //
            Console.WriteLine("\nHistoriek: ");
            for (i = 0; i < scores.Length; i++)
            {
                Console.Write($"{i + 1}: ");

                for (int aantalAsterken = 0; aantalAsterken < scores[i]; aantalAsterken++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                som += scores[i];
            }

            // Bereken het gemiddelde van de getallen
            // Gemiddelde: xx.xx
            Console.WriteLine($"\nhet gemiddelde = {som / aantal}");
        }
    }
}