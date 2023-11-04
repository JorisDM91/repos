namespace D09speelkaarten
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

            foreach (string kaart in speelkaarten)
            {
                Console.WriteLine(kaart);
            }
        }
    }
}