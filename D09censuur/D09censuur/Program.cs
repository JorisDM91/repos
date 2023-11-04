using System.Text.RegularExpressions;

namespace D09censuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] scheldwoorden = { "bengel", "schurk", "debiel", "eikel", "flapdrol", "geit", "hufter", "klojo", "loser", "appelflap" };

            Console.WriteLine("Voer een tekst in:");
            string ingevoerdeTekst = Console.ReadLine();

            string tekstInKleineLetters = ingevoerdeTekst.ToLower();

            // Maakt een reguliere expressiepatroon dat overeenkomt met alle scheldwoorden
            string patroon = string.Join("|", scheldwoorden);
            patroon = "\\b(" + patroon + ")\\b"; // Voeg word boundary markers toe

            // Vervangt scheldwoorden door sterretjes in de tekst
            string gecensureerdeTekst = Regex.Replace(tekstInKleineLetters, patroon, match => new string('*', match.Length));

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