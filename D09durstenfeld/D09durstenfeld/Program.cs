namespace D09durstenfeld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "boer", "dame", "koning", "aas" };

            string[] speelkaarten = new string[52];

            int index = 0;
            foreach (string kleur in kleuren)
            {
                foreach (string waarde in waarden)
                {
                    speelkaarten[index] = kleur + " " + waarde;
                    index++;
                }
            }

            // Durstenfeld shuffle (Fisher-Yates algoritme)
            Random random = new Random();
            for (int i = speelkaarten.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                string temp = speelkaarten[i];
                speelkaarten[i] = speelkaarten[j];
                speelkaarten[j] = temp;
            }

            foreach (string kaart in speelkaarten)
            {
                Console.WriteLine(kaart);
            }
        }
    }
}