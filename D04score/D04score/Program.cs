namespace D04score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker om een score vraagt (in procent) 
             * en vervolgens de Amerikaanse lettercode weergeeft.

                A indien score > 82%
                B indien score > 67% en <=82%
                C indien score > 52% en <=67%
                D indien score > 37% en <=52%
                E indien score > 22% en <=37%
                F indien score <= 22% */

            Console.WriteLine("Geef een score (in procent): ");
            double score = double.Parse(Console.ReadLine());

            char scoreUS;

            if (score > 82) 
            {
                scoreUS = 'A';
            }
            else if (score > 67)
            {
                scoreUS = 'B';
            }
            else if (score > 52)
            {
                scoreUS = 'C';
            }
            else if (score > 37)
            {
                scoreUS = 'D';
            }
            else if (score > 22)
            {
                scoreUS = 'E';
            }
            else
            {
                scoreUS = 'F';
            }

            Console.WriteLine($"De score is: " + scoreUS);

        }
    }
}