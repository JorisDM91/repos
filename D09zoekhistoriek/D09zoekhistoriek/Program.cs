namespace D09zoekhistoriek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zoekhistoriek = { "Charlie Sheen", "Hot shots", "Winning", "Electrabel storing", "Geen elektriciteit" };

            while (true)
            {
                Console.WriteLine(string.Join(":", zoekhistoriek));

                Console.Write("Nieuwe zoekterm: ");
                string nieuweZoekterm = Console.ReadLine();

                for (int i = 0; i < zoekhistoriek.Length - 1; i++)
                {
                    zoekhistoriek[i] = zoekhistoriek[i + 1];
                }
                zoekhistoriek[zoekhistoriek.Length - 1] = nieuweZoekterm;
            }
        }
    }
}