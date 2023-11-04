namespace TellerAantalGetallenDOWHILEmetControle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int getal = 0;
            int aantal = 0;
            do
            {
                Console.Write("Geef het volgende getal (-1 om te stoppen) : ");
                getal = int.Parse(Console.ReadLine());
                if (getal != -1)
                {
                    aantal++;
                }
            } while (getal != -1);
            Console.WriteLine($"u gaf {aantal} getallen in");
        }
    }
}