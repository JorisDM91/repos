namespace Interestvoet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Declareer de variabelen
            int kapitaal;
            double interestvoet;
            double interest;
            double eindkapitaal;

            // Ken een waarde toe aan elke variabeleµ
            Console.Write("Geef het kapitaal in: ");
            String ingegevenKapitaal = Console.ReadLine();
            kapitaal = int.Parse(ingegevenKapitaal);
            //Kapitaal = 10000;
            interestvoet = 0.01;

            // Berekening interest
            interest = kapitaal * interestvoet;
            eindkapitaal = interest + kapitaal;

            // Schrijf het resultaat weg naar het scherm
            Console.WriteLine($"Het startkapitaal is: {kapitaal} euro");
            Console.WriteLine($"De interestvoet bedraagt: {interestvoet} %");
            Console.WriteLine($"De interest bedraagt na één jaar: {interest:F2} euro");
            Console.WriteLine($"Het kapitaal na 1 jaar bedraagt {eindkapitaal} ");

            
        }
    }
}