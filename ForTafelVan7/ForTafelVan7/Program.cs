namespace ForTafelVan7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("loop 3 : begin 7, grens is <= 70, stapgrootte +7");
            for (int i = 7; i <= 70; i += 7)
            {
                int aantal = i / 7;
                int product = i;
                Console.WriteLine($"{aantal} x 7 = {product}");
            }
            Console.WriteLine();
        }
    }
}