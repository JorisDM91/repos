namespace D03kleinermetmathmin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            Herschrijf het programma uit de vorige oefening zodat dit keer wél Math.Min() gebruikt wordt.
            Console.Write("Geef een geheel getal in: ");
            int gg1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef een ander geheel getal in: ");
            int gg2 = Convert.ToInt32(Console.ReadLine());



            if (gg1 < gg2)
            {
                int gg1K = Math.Min(gg1, gg2);
                Console.WriteLine($"{gg1} is kleiner dan {gg2}.");
            }
            else if (gg2 < gg1)
            {
                int gg2K = Math.Min(gg2, gg1);
                Console.WriteLine($"{gg2} is kleiner dan {gg1}.");
            }
            else
            {
                Console.WriteLine("De 2 gehele getallen zijn gelijk.");
            }

            Console.ReadLine();

        }
    }
}