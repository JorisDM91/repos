using System.Text.RegularExpressions;

namespace D09censuuruitbreiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definieer een lijst met scheldwoorden (hoofdletterongevoelig)
            string[] scheldwoorden = { "bengel", "schurk", "debiel", "eikel", "flapdrol", "geit", "hufter", "klojo", "loser", "appelflap" };

            Console.WriteLine("Voer een tekst in:");
            string ingevoerdeTekst = Console.ReadLine();

            // Converteert de ingevoerde tekst naar kleine letters voor hoofdletterongevoelige vergelijking
            string tekstInKleineLetters = ingevoerdeTekst.ToLower();

            // Maakt een reguliere expressiepatroon dat overeenkomt met alle scheldwoorden
            string patroon = string.Join("|", scheldwoorden);
            patroon = "\\b(" + patroon + ")\\b"; // Voeg word boundary markers toe

            // Vervangt scheldwoorden door sterretjes in de tekst
            string gecensureerdeTekst = Regex.Replace(tekstInKleineLetters, patroon, match =>
            {
                // Behoud de eerste en laatste letters van het scheldwoord en vervang de tussenliggende letters door sterretjes
                string origineel = match.Value;
                string gecensureerd = origineel.Substring(0, 1) + new string('*', origineel.Length - 2) + origineel.Substring(origineel.Length - 1);
                return gecensureerd;
            });

            // Hersteld de hoofdletter- en kleine lettergevoeligheid van de oorspronkelijke tekst
            for (int i = 0; i < ingevoerdeTekst.Length; i++)
            {
                if (Char.IsUpper(ingevoerdeTekst[i]))
                {
                    gecensureerdeTekst = gecensureerdeTekst.Remove(i, 1).Insert(i, Char.ToUpper(gecensureerdeTekst[i]).ToString());
                }
            }

            Console.WriteLine("Censuurresultaat:");
            Console.WriteLine(gecensureerdeTekst);
        }
    }
}