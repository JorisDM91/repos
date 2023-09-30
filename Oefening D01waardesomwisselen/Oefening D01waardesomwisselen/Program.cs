namespace Oefening_D01waardesomwisselen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 13;

            // 	verwissel hier de inhoud van de variabelen a en b

            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}