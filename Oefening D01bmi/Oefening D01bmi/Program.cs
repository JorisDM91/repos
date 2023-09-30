namespace Oefening_D01bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengteInCm = 182;
            int gewichtInKg = 72;

            // bereken het bmi,
            // maak eventueel gebruik van extra variabelen,

            double lengteInMeter = (double)lengteInCm / 100;
            double lengteKwadraat = lengteInMeter * lengteInMeter;

            // en zorg ervoor dat de bmi waarde in de juiste variabele terechtkomt

            double bmi = gewichtInKg / lengteKwadraat;
            
            Console.WriteLine(bmi);

        }
    }
}
