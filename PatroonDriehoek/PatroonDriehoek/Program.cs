namespace PatroonDriehoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoogte = 10;

            for (int rij = 1; rij <= hoogte; rij++)
            {
                for (int kolom = 1; kolom <= rij; kolom++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}