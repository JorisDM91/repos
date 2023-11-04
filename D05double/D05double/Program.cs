using System.Linq.Expressions;

namespace D05double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Voer een (double) getal in: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double getal))
                {
                    Console.WriteLine("Geef aub een volgend getal: ");
                }
                else
                {
                    Console.WriteLine("Einde (wegens geen double getal). ");
                    break;
                }
            }
        }
    }
}