namespace SchaarSteenPapierList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> opties = new List<string> { "schaar", "steen", "papier", "rock", "paper", "scissors" };

            Console.WriteLine("Welkom bij Schaar, Steen, Papier / Rock, Paper, Scissors!");
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            Console.WriteLine("Beslis je zet: schaar, steen of papier? / rock, paper, scissors? ");
            string spelerKeuze = Console.ReadLine();

            Random willekeur = new Random();
            int willekeurigeIndex = willekeur.Next(opties.Count);
            string computerKeuze = opties[willekeurigeIndex];

            Console.WriteLine($"De computer koos: {computerKeuze}");
            Console.WriteLine($"The computer chose: {computerKeuze}");

            Console.WriteLine($"Jij koos: {spelerKeuze}");
            Console.WriteLine($"You chose: {spelerKeuze}");


            if (spelerKeuze == computerKeuze)
            {
                Console.WriteLine("Gelijkspel!");
                Console.WriteLine("Draw!");

            }
            else if ((spelerKeuze == "schaar" && computerKeuze == "papier") ||
                     (spelerKeuze == "steen" && computerKeuze == "schaar") ||
                     (spelerKeuze == "papier" && computerKeuze == "steen") ||
                     (spelerKeuze == "scissors" && computerKeuze == "paper") ||
                     (spelerKeuze == "rock" && computerKeuze == "scissors") ||
                     (spelerKeuze == "paper" && computerKeuze == "rock"))

            {
                Console.WriteLine("Jij wint!");
                Console.WriteLine("You win!");

            }
            else
            {
                Console.WriteLine("De computer wint!");
                Console.WriteLine("The computer wins!");

            }
        }
    }
}