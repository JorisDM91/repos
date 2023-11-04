namespace WerkcollegeD05WhileLus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teller = 0;
            int som = 0;
            while (teller < 5)
            {
                Console.Write($"Geef getal {teller + 1} in: ");
                try
                {
                    int getal = int.Parse(Console.ReadLine());
                    som += getal;
                }
                catch
                {
                    Console.WriteLine("Ongeldige input, geef opnieuw een getal in: ");
                    continue;
                }

                teller++;
            }
            Console.WriteLine($"De som van de getallen = {som}");
        }
    }
}