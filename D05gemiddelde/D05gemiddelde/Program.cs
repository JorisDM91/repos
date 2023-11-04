using System.ComponentModel.DataAnnotations;

namespace D05gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker meermaals om een getal vraagt 
             * (totdat de gebruiker een -1 ingeeft).
             * Voor de eenvoud gaan we er hier van uit dat de gebruiker netjes getallen invoert, 
             * je hoeft hier niet op te controleren.
             Na afloop toont het programma wat het GEMIDDELDE is van alle getallen 
             (de ingegeven -1 telt niet mee). */


            // * Schrijf een programma dat de gebruiker meermaals om een getal vraagt 
            //*(totdat de gebruiker een - 1 ingeeft).

            {
                int totaal = 0;
                int teller = 0;

                while (true)
                {
                    Console.Write("Voer een getal in (typ -1 om te stoppen): ");
                    int getal = int.Parse(Console.ReadLine());

                    if (getal == -1)
                        break;

                    totaal += getal;
                    teller++;
                }

                if (teller > 0)
                {
                    double gemiddelde = (double)totaal / teller;
                    Console.WriteLine($"Het gemiddelde van de ingevoerde getallen is: {gemiddelde}");

                }
            }
        }
    }
}