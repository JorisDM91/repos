namespace D04Toelage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Een bepaalde instantie voorziet in een toelage bovenop het inkomen van grote minderbedeelde gezinnen. 
             * De toelage - bedraagt 3% van het jaarinkomen - vervalt indien het jaarinkomen meer is dan 20000Eur of het aantal kinderen minder is dan 3.

            Schrijf een programma dat de gebruiker om het jaarinkomen en aantal kinderen vraagt, en vervolgens de toelage voor dat gezin toont. */


            Console.WriteLine("Geef het jaarinkomen in: ");
            double jaarInkomen = double.Parse(Console.ReadLine());

            Console.WriteLine("Geef aantal kinderen: ");
            int aantalKinderen = int.Parse(Console.ReadLine());

            double toelage = jaarInkomen * 1.03;
            double resultaat; 
            resultaat = toelage - jaarInkomen;

            if (jaarInkomen > 20000)
            {
                Console.WriteLine("U heeft geen recht op toelage.");
            }
            else if (aantalKinderen > 2) 
            {
                Console.WriteLine("U heeft geen recht op toelage.");
            }
            else 
            {
                Console.WriteLine($"Uw toelage bedraagt {resultaat:F2} euro.");
            }

        }
    }
}