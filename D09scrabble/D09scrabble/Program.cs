namespace D09scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord: ");
            string ingevoerdWoord = Console.ReadLine().ToLower();

            int[] letterScores = { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };

            int totaleScore = 0;
            string scoreBerekening = "";

            foreach (char letter in ingevoerdWoord)
            {
                int index = letter - 'a';

                if (index >= 0 && index < letterScores.Length)
                {
                    int letterScore = letterScores[index];
                    totaleScore += letterScore;
                    scoreBerekening += $"{letterScore} + ";
                }
            }

            if (scoreBerekening.Length > 0)
            {
                scoreBerekening = scoreBerekening.TrimEnd('+');
                Console.WriteLine($"Dat woord is {scoreBerekening}= {totaleScore} punten waard.");
            }
            else
            {
                Console.WriteLine("Ongeldige invoer: geen letters gevonden.");
            }
        }
    }
}