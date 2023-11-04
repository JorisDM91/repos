namespace D06getallenuitrij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat alle getallen toont
            // uit de rij 10, 9, …​, 2.

            int getal2 = 2;

            for (int getal1 = 10; getal1 >= getal2; getal1--) 
            {
                Console.WriteLine(getal1);
            }

        }
    }
}