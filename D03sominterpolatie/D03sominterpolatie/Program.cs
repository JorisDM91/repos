namespace D03sominterpolatie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Herwerk de oplossing van D02som zodat string interpolatie gebruikt wordt.

            Console.Write("Voer het eerste gehele getal in: ");
            if (int.TryParse(Console.ReadLine(), out int getal1))
            {
                Console.Write("Voer het tweede gehele getal in: ");
                if (int.TryParse(Console.ReadLine(), out int getal2))
                {
                    int som = getal1 + getal2;
                    Console.WriteLine($"{getal1} plus {getal2} is {som}.");
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer voor het tweede getal.");
                }
            }
            else
            {
                Console.WriteLine("Ongeldige invoer voor het eerste getal.");

            }
        }
    }
}