namespace D03imperial
{
    internal class Program
    {
        // Vervang de magic values in dit programma door const variabelen
        const double FeetToCm = 30.48;   // conversie van Feet naar Centimeters
        const double InchesToCm = 2.54;  // conversie van Inch naar Centimeters

        static void Main(string[] args)
        {
            Console.Write("Geef het aantal feet : ");
            string aantalFeetAlsTekst = Console.ReadLine();
            // string aantalFeetAlsTekst omzetten naar double
            double aantalFeet = double.Parse(aantalFeetAlsTekst);

            Console.Write("Geef het aantal inches : ");
            string aantalInchesAlsTekst = Console.ReadLine();
            double aantalInches = double.Parse(aantalInchesAlsTekst);

            double aantalFeetInCm = aantalFeet * FeetToCm;
            double aantalInchesInCm = aantalInches * InchesToCm;

            double totaalInCm = aantalFeetInCm + aantalInchesInCm;

            // totaalInCm afronden tot 2 cijfers na de komma;
            double totaalInCmAfgrnd = Math.Round(totaalInCm, 2);

            Console.WriteLine($"Dat is {totaalInCmAfgrnd}cm.");

        }
    }
}