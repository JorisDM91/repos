using System.Net;

namespace D06getallentussen20en30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat alle getallen TUSSEN 20 en 30 toont(dus 21, …​, 29).

            int getal2 = 30 -1;

            for (int getal1 = 20 + 1; getal1 <= getal2; getal1++) 
            {
                Console.WriteLine(getal1);
            }

        }
    }
}