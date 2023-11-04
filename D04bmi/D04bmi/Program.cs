using System.Diagnostics.Metrics;
using System.Net;

namespace D04bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maak een programma om onderstaand programmaverloop te bekomen…​ . (In het getoonde scenario werd 153 en 84 ingevoerd.)

            Lengte in cm ?: 153
            Gewicht in kg ?: 84
            BMI: 35,8836344995515(zwaarlijvigheid)

            Er wordt gevraagd naar de lengte in centimeter en het gewicht in kilogram.
            Na invoer van de gebruiker zal ons programma 
            de body mass index(gewicht-in-kilogram / lengte -in-meter²) berekenen en afdrukken.
            Niet allen het bmi maar ook de bijhorende omschrijving(ondergewicht, normaal gewicht, overgewicht, …​) 
            wordt door het programma afgedrukt.

            * Onder de 18,5: ondergewicht.

            * Vanaf 18,5 en minder dan 25: normaal gewicht.

            * Vanaf 25 en minder dan 30: overgewicht.

            * Vanaf 30 en minder dan 40: zwaarlijvigheid.

            * Vanaf 40: ernstige zwaarlijvigheid. */

            Console.WriteLine("Geef lengte in centimeter: ");
            double lengteCM = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef gewicht in kilogram: ");
            double gewichtKG = double.Parse(Console.ReadLine());

            double BMI;
            double lengteM = lengteCM / 100;

            BMI = gewichtKG / (lengteM * 2);
            Console.Write($"Uw BMI is {BMI}");

            if (BMI < 18.5)
            {
                Console.Write("(ondergewicht)");
            }
            else if (BMI < 25) 
            {
                Console.WriteLine("(normaal gewicht)");
            }
            else if (BMI < 30)
            {
                Console.WriteLine("(overgewicht)");
            }
            else if (BMI < 40)
            {
                Console.WriteLine("(zwaarlijvigheid)");
            }
            else if (BMI > 40)
            {
                Console.WriteLine("(ernstige zwaarlijvigheid)");
            }

        }
    }
}