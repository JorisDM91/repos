namespace D09geenscheldwoorden
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] scheldwoorden = { "bengel", "schurk", "debiel", "eikel", "flapdrol", "geit", "hufter", "klojo", "loser", "appelflap" };

            Console.WriteLine("Voer een tekst in:");
            string ingevoerdeTekst = Console.ReadLine();

            string tekstInKleineLetters = ingevoerdeTekst.ToLower();

            bool bevatScheldwoord = false;

            foreach (string scheldwoord in scheldwoorden)
            {
                if (tekstInKleineLetters.Contains(scheldwoord.ToLower()))
                {
                    bevatScheldwoord = true;
                    break;
                }
            }

            if (bevatScheldwoord)
            {
                Console.WriteLine("De ingevoerde tekst bevat scheldwoorden en is niet aanvaardbaar.");
            }
            else
            {
                Console.WriteLine("De ingevoerde tekst is aanvaardbaar.");
            }
        }
    }
}