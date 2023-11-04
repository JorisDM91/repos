namespace ProgrammaPauzeren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int aantalMillisecondenPerSeconde = 1000;

            Console.Write("Hoeveel seconden wil u uw adem inhouden : ");
            int aantalSeconden = int.Parse(Console.ReadLine());

            int aantalMilliseconden = aantalSeconden * aantalMillisecondenPerSeconde;

            Console.WriteLine("We gaan dit eens testen, hou nu uw adem in...");

            System.Threading.Thread.Sleep(aantalMilliseconden); // wacht

            Console.WriteLine($"U kunt weer ademhalen, er zijn {aantalSeconden} seconden verstreken.");
        }
    }
}