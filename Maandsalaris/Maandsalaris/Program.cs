namespace Maandsalaris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maandsalaris");

            Console.Write("Geef maandsalaris in euro: ");
            double maandSalaris = double.Parse(Console.ReadLine());
            double jaarSalaris = maandSalaris * 12;
            double vakantieGeld = jaarSalaris * 0.08;
            Console.WriteLine($"jaarsalaris {jaarSalaris}");
            Console.WriteLine($"vakantiegeld {vakantieGeld}");

        }
    }
}