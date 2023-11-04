namespace WerkcollegeD5_D6oef13Algoritme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Werk een applicatie met een main-methode uit die aan de gebruiker een strikt positief geheel getal vraagt 
             * en controleert.
             * Als het even is, deel het getal door 2.
             * Als het oneven is, vermenigvuldig het getal met 3 
             * en tel er 1 bij op. 
             * Zo bekom je een nieuw getal.
             * Herhaal deze bewerkingen op het nieuwe getal tot je 1 bekomt.
             * Toon op het scherm hoelang het duurt, m.a.w 
             * hoeveel keer het getal wijzigt tot het gelijk is aan 1.8 */

            int getal;

            // Input
            while (true)
            {
                Console.Write($"Geef een strikt positief geheel getal in: ");
                try
                {
                    getal = int.Parse(Console.ReadLine());

                    if (getal > 0)
                    {
                        break;
                    }
                }
                catch
                {

                }

                Console.WriteLine("Ongeldige input! Probeer opnieuw... ");
            }

            // Bewerking
            int teller = 0;

            while (getal > 1) // (getal != 1)
            {
                teller++;

                if (getal % 2 == 0)
                {
                    getal /= 2;
                }
                else
                {
                    getal = getal * 3 + 1;
                }
            }

            // Output
            Console.WriteLine($"Het getal wijzigt {teller} {(teller == 1 ? "keer" : "keren")}.");
        }
    }
}