using System.Diagnostics;

namespace D03traceerpersecondewijzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Schrijf een programma dat de gebruiker om een geheel aantal seconden vraagt
            // en toont hoeveel uren, minuten en seconden dit is.

            //Maak de traceertabel voor de oplossing van D03persecondewijzer hierboven,
            //als de gebruiker 8587 ingeeft voor het aantal seconden.
            int totaalSeconden = 8587;

            // Vraag de gebruiker om een geheel aantal seconden
            Console.WriteLine("Aantal seconden: 8587");
            
            // Start traceertabel
            Console.WriteLine("Traceertabel:");
            Console.WriteLine("---------------");

            // Stap 1
            Console.WriteLine("1. Vraag de gebruiker om een geheel aantal seconden in te voeren.");

            // Stap 2
            Console.WriteLine("2. Lees het ingevoerde aantal seconden en sla het op in de variabele \"totaalSeconden\".");
            Console.WriteLine($"   Ingevoerde waarde: {totaalSeconden}");

            // Bereken het aantal uren
            int uren = totaalSeconden / 3600; // 1 uur = 3600 seconden
            totaalSeconden %= 3600;

            // Stap 3
            Console.WriteLine("3. Bereken het aantal uren:");
            Console.WriteLine($"   3a. Verdeel \"totaalSeconden\" door 3600 (1 uur = 3600 seconden).");
            Console.WriteLine($"   3b. Sla het resultaat op in de variabele \"uren\".");
            Console.WriteLine($"       Uren: {uren}");
            Console.WriteLine($"   3c. Bereken de restwaarde van \"totaalSeconden\" na deling door 3600 en sla deze waarde terug in \"totaalSeconden\".");
            Console.WriteLine($"       Resterende seconden: {totaalSeconden}");

            // Bereken het aantal minuten
            int minuten = totaalSeconden / 60; // 1 minuut = 60 seconden
            totaalSeconden %= 60;

            // Stap 4
            Console.WriteLine("4. Bereken het aantal minuten:");
            Console.WriteLine($"   4a. Verdeel \"totaalSeconden\" door 60 (1 minuut = 60 seconden).");
            Console.WriteLine($"   4b. Sla het resultaat op in de variabele \"minuten\".");
            Console.WriteLine($"       Minuten: {minuten}");
            Console.WriteLine($"   4c. Bereken de restwaarde van \"totaalSeconden\" na deling door 60 en sla deze waarde terug in \"totaalSeconden\".");
            Console.WriteLine($"       Resterende seconden: {totaalSeconden}");

            // Het overgebleven aantal seconden is al berekend in de voorgaande stappen

            // Toon het resultaat
            Console.WriteLine("5. Toon het resultaat aan de gebruiker:");
            Console.WriteLine();
            Console.WriteLine($"   Dit is gelijk aan: ");
            Console.WriteLine($"   {uren} uur");
            Console.WriteLine($"   {minuten} minuten");
            Console.WriteLine($"   {totaalSeconden} seconden.");

        }
    }
}