namespace StringArrayDagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dagen;
            dagen = new string[7];

            dagen[0] = "maandag";
            dagen[1] = "dinsdag";
            //...
            dagen[5] = "zaterdag";
            dagen[6] = "zondag";

            Console.WriteLine("De 6de dag is: " + dagen[5]);
            Console.WriteLine("Aantal dagen: " + dagen.Length);

            // uitvoer:
            // De 6de dag is: zaterdag
            // Aantal dagen: 7
        }
    }
}