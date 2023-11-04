namespace D03kleinermetif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker om twee gehele getallen vraagt 
             * en toont welk getal het kleinste is. 
             * Gebruik hiervoor - bij wijze van oefening - eens een if/else structuur en niet Math.Min()!

              Een mogelijke uitvoering :

                Geef een getal : 12
                Geef een ander getal : 56
                12 is kleiner. */

            Console.Write("Geef een geheel getal in: ");
            int gg1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geef een ander geheel getal in: ");
            int gg2 = Convert.ToInt32(Console.ReadLine());

            if (gg1 < gg2)
            {
                Console.WriteLine($"{gg1} is kleiner dan {gg2}.");
            }
            else if (gg2 < gg1)
            {
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