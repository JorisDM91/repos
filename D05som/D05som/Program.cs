using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace D05som
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker 
             * meermaals om een getal vraagt(totdat de gebruiker een - 1 ingeeft).
             * Voor de eenvoud gaan we er hier van uit 
             * dat de gebruiker netjes getallen invoert, 
             * je hoeft hier niet op te controleren.
              Na afloop toont het programma 
              wat de SOM is van alle getallen
              (de ingegeven - 1 telt niet mee).*/

            int input;
            int som = 0;

            Console.WriteLine("Geef meerdere getallen in (-1 om te stoppen): ");
            
            do {
                input = int.Parse(Console.ReadLine());

                if (input != -1)
                {
                    som += input;
                }
            } while (input != -1);

            Console.Write("De som van alle getallen (zonder -1) is " + som);

        }
    }
}