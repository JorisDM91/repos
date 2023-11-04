namespace ArrayFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Frequency
            // De gebruiker wordt gevraagd om een enquête in te vullen
            // en daarbij gaat hij elke vraag beantwoorden met een keuze
            // in het bereik [1;5]. Hij stopt met vragen beantwoorden door
            // het karakter 's' in te geven.

            // Hou de frequentie van alle antwoorden bij en druk deze nadien
            // af in tabelvorm:
            // 
            // Keuze   Frequency
            //     1           3
            //     2           4
            //     3           8
            //     4           5
            //     5           2

            int[] teller = new int[5];

            while (true)
            {
                Console.Write("1-5? (typ 's' om te stoppen) : ");
                string input = Console.ReadLine();

                if (input == "s")
                {
                    break;
                }

                if (int.TryParse(input, out int getal) && getal >= 1 && getal <= 5)
                {
                    teller[getal - 1]++;
                }
                else
                {
                    Console.WriteLine("Ongeldige input, probeer opnieuw.");
                }
            }

            Console.WriteLine("Keuze\tFrequency");

            for (int i = 0; i < teller.Length; i++)
            {
                Console.WriteLine($"{i + 1,5}\t{teller[i],9}");
            }

            /*int keuze = 1;

            foreach (int aantalKeer in teller)
            {
                Console.WriteLine($"{keuze,5}\t{aantalKeer,9}");
                keuze++;
            }*/
        }
    }
}