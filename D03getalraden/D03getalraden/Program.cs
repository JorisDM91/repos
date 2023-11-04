using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D03getalraden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat een random getal bepaalt tussen 0 en 10
            // en de gebruiker 1 kans geeft om het te raden.
            // Het programma toont of de gok van de gebruiker juist of fout was
            // Een mogelijke uitvoering waarbij het random getal 4 is en de gebruiker 8 gokt:
            // De computer denkt aan een getal tussen 0 en 10.
            // Welk getal denkt u dat het is : 8
            // Helaas, het getal was 4!

            // genereert random getal tussen 1 en 10

            Random random = new Random();
            int randomGetal = random.Next(0, 11);

            Console.WriteLine("De computer denkt aan een getal tussen 0 en 10");
            Console.Write("Welk getal denkt u dat het is : ");

            
            int gebruikerGetal = Convert.ToInt32(Console.ReadLine());

            // programma (if-else block) toont of de gok van de gebruiker juist of fout was

            if (randomGetal == gebruikerGetal)
            {
                Console.WriteLine("Proficiat, uw gok is juist");
            }
            else
            {
                Console.WriteLine($"Helaas, het getal was {randomGetal}.");
            }

            Console.ReadLine();

        }
    }
}