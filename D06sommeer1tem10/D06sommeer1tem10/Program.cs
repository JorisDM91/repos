namespace D06sommeer1tem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;

            for (int i = 0; i <= 10; i++) 
            {
                som += i * i;
            }

            Console.WriteLine($"De som van alle kwadraten van 1 tot en met 10 = {som}");
        
        }
    }
}