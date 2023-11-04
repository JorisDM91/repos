namespace D05tafelsvan7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maak een programma dat het resultaat 
             * van de vermenigvuldiging van het getal 7 
             * met de factoren 1 tot en met 10 gaat weergeven.
                Doe dit aan de hand van een herhalingsstructuur, 
                werk met een do while statement.
                Zorg voor volgende uitvoer op de console…​

                1 x 7 = 7
                2 x 7 = 14
                3 x 7 = 21
                4 x 7 = 28
                5 x 7 = 35
                6 x 7 = 42
                7 x 7 = 49
                8 x 7 = 56
                9 x 7 = 63
                10 x 7 = 70 */

            int factor = 1;
            int getal = 7;

            do
            {
                int resultaat = factor * getal;
                Console.WriteLine($"{factor} x {getal} = {resultaat}");
                factor++;
            } while (factor <= 10);
        }
    }
}