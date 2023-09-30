namespace D01Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            Console.WriteLine("Geef eerste getal: ");
            double getal1= double.Parse(Console.ReadLine());
            Console.WriteLine("Geef tweede getal: ");
            double getal2= double.Parse(Console.ReadLine());
            Console.WriteLine("Geef derde getal: ");
            double getal3= double.Parse(Console.ReadLine());

            double bewerking = getal1 * getal2 * getal3;

            Console.WriteLine($"Het resultaat van de vermenigvuldiging van {getal1} , {getal2} , en {getal3} is {bewerking}");
        }
    }
}