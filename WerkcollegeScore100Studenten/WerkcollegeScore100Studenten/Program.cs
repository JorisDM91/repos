namespace WerkcollegeScore100Studenten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[100]; // new keyword: array aanmaken
            int index;

            // Vul bovenstaande array op met de tafel van 2;

            for (index = 0; index < scores.Length; index++) // .Length = 
            {
                scores[index] = (index + 1) * 2;
            }

            for (index = 0; index < scores.Length; index++)
            {
                Console.WriteLine(scores[index]);
            }
        }
    }
}