namespace D08omgekeerdevolgordehoeveel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Hoeveel namen wil je invoeren? ");
                int aantalNamen = int.Parse(Console.ReadLine());

                string[] namen = new string[aantalNamen];

                for (int i = 0; i < aantalNamen; i++)
                {
                    Console.Write($"Geef naam {i + 1} : ");
                    namen[i] = Console.ReadLine();
                }

                Console.WriteLine("Namen in omgekeerde volgorde:");
                for (int i = aantalNamen - 1; i >= 0; i--)
                {
                    Console.WriteLine(namen[i]);
                }
            }
        }
    }
}