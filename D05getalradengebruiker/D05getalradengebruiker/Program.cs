using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;

namespace D05getalradengebruiker
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Schrijf een programma waarbij de gebruiker een getal moet raden(van 1 t.e.m. 100) 
            * dat de computer willekeurig gekozen heeft.
              De gebruiker geeft telkens een getal in 
              en het programma toont of het gezochte getal "Hoger!" dan wel "Lager" is dan de gok.
              Indien de gebruiker correct gokt, toont het programma "Disco!"
              Een voorbeeld uitvoering waarbij het programma willekeurig voor 74 koos en de gebruiker achtereenvolgens 50, 75, 67, 72 en 74 gokt:

                Wat gok je ?: 50
                Hoger!
                Wat gok je ?: 75
                Lager!
                Wat gok je ?: 67
                Hoger!
                Wat gok je ?: 72
                Hoger!
                Wat gok je ?: 74
                Disco! */

            Random raden = new Random();
            int getal = raden.Next(1,101);
            int gok;
            Console.WriteLine("Raad het getal...");
            do
            {
                Console.Write("Wat gok je? (1 tem 100): ");
                string input = Console.ReadLine();
                gok = int.Parse(input);
                if (gok < getal)
                {
                    Console.WriteLine("Hoger!");
                }
                else if (gok > getal)
                {
                    Console.WriteLine("Lager!");
                }
                else
                {
                    Console.WriteLine("Disco!");
                }

            } while (gok != getal);
        }
    }
}