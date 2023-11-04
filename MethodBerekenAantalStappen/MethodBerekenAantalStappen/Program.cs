using System.Security.Cryptography.X509Certificates;

namespace MethodBerekenAantalStappen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implementeer volgend algoritme in een methode.
            // Het algoritme berekend het aantal stappen nodig om tot het getal 1 te komen.
            // Het algoritme vertrekt van een geheel getal groter dan 1.
            //
            // Hoe wordt het algoritme uitgewerkt:
            // - Als het getal oneven is, dan wordt het getal omgezet met
            //   volgende formule: N = 3 * N + 1
            // - Als het getal even is wordt het gedeeld door 2

            // Reken vervolgens het aantal stappen uit voor de getallen 2 tem 100 en 
            // plaats het resultaat op het scherm.

            for (int i = 2; i <= 100; i++)
            {
                Console.WriteLine($"Het startgetal is {i}.");
                int resultaat = BerekenAantalStappen3N_1(i);
                Console.WriteLine($"Het aantal stappen is: {resultaat}");
            }
        }
        // aanmaak van method
        public static int BerekenAantalStappen3N_1(int getal)
        {
            // Wat als het getal kleiner of gelijk is aan 1: dit mag niet volgens de opgave
            if (getal <= 1)
            {
                // Onderbreek de methode met een exceptie
                // Geef in de exceptie aan om welke parameter het gaat: nameof(getal)
                // Geef ook een duidelijk boodschap mee die aangeeft wat er misliep.
                throw new ArgumentOutOfRangeException(nameof(getal), "Getal moet groter zijn dan 1.");
            }

            // Voer algoritme uit en hou de stappen bij;

            int aantalStappen = 0;

            while (true)
            {
                aantalStappen++;

                if (getal % 2 == 1)
                {
                    getal = 3 * getal + 1;
                }
                else
                {
                    getal /= 2;
                }

                if (getal == 1)
                {
                    break;
                }
            }
            return aantalStappen;
        }
    }
}