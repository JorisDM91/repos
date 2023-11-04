namespace D08omgekeerdevolgorde
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] namen = new string[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Geef naam {i + 1} : ");
                namen[i] = Console.ReadLine();
            }

            Console.WriteLine("Namen in omgekeerde volgorde:");
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(namen[i]);
            }
        }
    }
}