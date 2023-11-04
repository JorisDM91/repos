namespace D07veelvoudenvan9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factor = 9;
            int n = 1;

            for (int i = 1; i <= 8; i++)
            {
                int result = n * factor;
                Console.WriteLine($"{n,2} x {factor} = {result,3}");
                n += 2;
            }
        }
    }
}