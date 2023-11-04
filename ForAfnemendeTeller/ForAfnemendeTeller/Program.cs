namespace ForAfnemendeTeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("beginwaarde is 10, voorwaarde is >= 1, stapgrootte -1");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("beginwaarde is 30, voorwaarde is >= 10, stapgrootte -5");
            for (int i = 30; i >= 10; i -= 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}