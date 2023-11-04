namespace D04bmiKort
{ using System;

class Program
{
    
        static void Main()
        {
            Console.Write("Geef lengte in centimeter: ");
            double lengteCM = double.Parse(Console.ReadLine());

            Console.Write("Geef gewicht in kilogram: ");
            double gewichtKG = double.Parse(Console.ReadLine());

            double BMI = gewichtKG / Math.Pow(lengteCM / 100, 2);

            string omschrijving =

                BMI < 18.5 ? "ondergewicht" :
                BMI < 25 ? "normaal gewicht" :
                BMI < 30 ? "overgewicht" :
                BMI < 40 ? "zwaarlijvigheid" : "ernstige zwaarlijvigheid";

            Console.WriteLine($"Uw BMI is {BMI:F2} ({omschrijving})");
        }
    }
}