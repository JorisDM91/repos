namespace Oefening_D01codepositioneren
{
    internal class Program
    {
        static void Main(string[] args)
        {

Random r = new Random();
            int getal = r.Next(1, 101);
            int gok = 0;
            Console.WriteLine("De computer denkt aan een getal van 1 tem 100, kun je raden welk?");
            do
            {
                Console.Write("Wat gok je?: ");
                string input = Console.ReadLine();
                gok = int.Parse(input);
                if (gok < getal)
                {
                    Console.WriteLine("Hoger!");
                }
                else if (gok > getal)
                {
                    Console.WriteLine("Lager!");
                }
                else
                {
                    Console.WriteLine("Disco!");
                }
            } while (gok != getal);
        }
    }
}