namespace D07cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de straal van een cirkel: ");
            if (double.TryParse(Console.ReadLine(), out double straal) && straal > 0)
            {
                double omtrek = 2 * Math.PI * straal;
                double oppervlakte = Math.PI * Math.Pow(straal, 2);

                Console.WriteLine($"De omtrek is {omtrek:F3}.");
                Console.WriteLine($"De oppervlakte is {oppervlakte:F3}.");
            }
            else
            {
                Console.WriteLine("Ongeldige invoer. Voer een positief getal in voor de straal.");
            }
        }
    }
}