namespace D09morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string opgebouwdeTekst = "";

            while (true)
            {
                Console.Write("Morse code voor de volgende letter (. voor kort, - voor lang)?: ");
                string morseCode = Console.ReadLine();

                if (morseCode == "")
                {
                    break;
                }

                bool geldigeCode = false;
                char letter = ' ';

                for (int i = 0; i < morse.Length; i++)
                {
                    if (morseCode == morse[i])
                    {
                        geldigeCode = true;
                        letter = letters[i];
                        break;
                    }
                }

                if (geldigeCode)
                {
                    opgebouwdeTekst += letter;
                    Console.WriteLine($"Opgebouwde tekst tot nu toe: {opgebouwdeTekst}");
                }
                else
                {
                    Console.WriteLine("Ongeldige morse code!");
                    Console.WriteLine($"Opgebouwde tekst tot nu toe: {opgebouwdeTekst}");
                }
            }
        }
    }
}