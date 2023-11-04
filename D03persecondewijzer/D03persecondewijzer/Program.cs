namespace D03persecondewijzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Schrijf een programma dat de gebruiker om een geheel aantal seconden vraagt
            // en toont hoeveel uren, minuten en seconden dit is.


            // Vraag de gebruiker om een geheel aantal seconden
            Console.Write("Voer een geheel aantal seconden in: ");
            int totaalSeconden = int.Parse(Console.ReadLine());

            // Bereken aantal uren
            int uren = totaalSeconden / 3600; // 1 uur = 3600 seconden
            totaalSeconden %= 3600;

            // Bereken aantal minuten
            int minuten = totaalSeconden / 60; // 1 minuut = 60 seconden
            totaalSeconden %= 60;

            // rest = seconden
            Console.WriteLine($"Dit is gelijk aan: {uren} uur.");
            Console.WriteLine($"Dit is gelijk aan: {minuten} minuten.");
            Console.WriteLine($"Dit is gelijk aan: {totaalSeconden} seconden.");

        }
    }
}