namespace D05_Werkcollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;
            int x = 1; 
            int total = 0;

            while (x <= 10)
            {
                y = x * x;
                Console.WriteLine($"{y}");
                total += y;
                ++x;
            }

            Console.WriteLine($"Total is {total}");

        }
    }
}