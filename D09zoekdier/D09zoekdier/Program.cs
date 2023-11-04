namespace D09zoekdier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            Console.WriteLine("Voer een dier in: ");
            string ingevoerdDier = Console.ReadLine().ToLower();

            if (Array.Exists(boerderijDieren, dier => dier.ToLower() == ingevoerdDier))
            {
                Console.WriteLine("Dit is een boerderijdier. ");
            }
            else
            {
                Console.WriteLine("Dit is geen boerderijdier. ");
            }
        }
    }
}