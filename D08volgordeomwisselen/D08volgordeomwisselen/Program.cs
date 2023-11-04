namespace D08volgordeomwisselen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel namen wil je invoeren? ");
            int aantalNamen = int.Parse(Console.ReadLine());

            string[] namen = new string[aantalNamen];

            for (int i = 0; i < aantalNamen; i++)
            {
                Console.Write($"Geef naam {i + 1} : ");
                namen[i] = Console.ReadLine();
            }

            for (int i = 0; i < namen.Length / 2; i++)
            {
                string temp = namen[i];
                namen[i] = namen[namen.Length - 1 - i];
                namen[namen.Length - 1 - i] = temp;
            }

            Console.WriteLine("Namen in omgekeerde volgorde:");
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i]);
            }
        }
    }
}