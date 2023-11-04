namespace ForOplopendeTeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("beginwaarde is 1, voorwaarde is <= 10, stapgrootte +1");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("beginwaarde is 10, voorwaarde is <= 30, stapgrootte +5");
            for (int i = 10; i <= 30; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}