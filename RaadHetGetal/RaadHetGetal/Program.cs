namespace RaadHetGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Guessing game
            // Laat de computer een willekeurig getal kiezen tussen [1;100].
            // Laat de gebruiker dat getal raden (met opvang van verkeerde input).
            // De computer geeft aan het het getal te hoog of te laag.
            // De gebruiker kan 6 keer raden.

            // Resultaat van het spel: gewonnen of verloren in xxx beurten.

            // Na het spel wordt de vraag gesteld of de gebruiker
            // opnieuw wenst te spelen.

            int aantalKeerSpelen = VraagGetalBinnenBereik("Hoeveel keer wenst u het spel te spelen?",
                                                          "U gaf geen getal in, probeer opnieuw.",
                                                          1, 10);

            int aantalKeerGespeeld = 0;

            bool herhaalSpel = true;
            do
            {
                SpeelSpel();

                aantalKeerGespeeld++;

                if (aantalKeerGespeeld == aantalKeerSpelen)
                    break;

                herhaalSpel = StelEenJaNeeVraag("Wenst u opnieuw te spelen?");
            } while (herhaalSpel);
        }

        public static bool StelEenJaNeeVraag(string vraag)
        {
            bool result;

            do
            {
                Console.Write(vraag);

                string antwoord = Console.ReadLine();
                antwoord = antwoord.ToLower();
                antwoord = antwoord.Trim();

                switch (antwoord)
                {
                    case "nee":
                        result = false; break;
                    case "ja":
                        result = true; break;
                    default:
                        Console.WriteLine("Gelieve Ja of Nee in te geven.");
                        continue;
                }

                break;
            } while (true);

            return result;
        }

        public static void SpeelSpel()
        {
            const int MaximumGetal = 100;

            Random randomGetal = new Random();
            int getal = randomGetal.Next(MaximumGetal) + 1;

            Console.WriteLine("We spelen een spel raad het getal.");

            int aantalKeer = 0;
            while (aantalKeer < 6)
            {
                int inputGetal = VraagGetalBinnenBereik("Raad een nummer", "Geef een geldig getal in!", 1, MaximumGetal + 1);

                if (inputGetal == getal)
                {
                    Console.WriteLine("Je hebt goed geraden!!");
                    break;
                }

                if (inputGetal > getal)
                {
                    Console.WriteLine("Je hebt te hoog geraden");
                }
                else
                {
                    Console.WriteLine("Je hebt te laag geraden ");
                }

                aantalKeer++;
            }
            Console.WriteLine($"Het getal was  {getal}");
        }

        public static int VraagGetalBinnenBereik(string vraag, string verkeerdeInput, int min, int max)
        {
            int getal;
            Console.Write(vraag + " ");

            while (true)
            {
                try
                {
                    getal = int.Parse(Console.ReadLine());

                    if (getal >= min && getal < max)
                    {
                        return getal;
                    }
                    else
                    {
                        Console.WriteLine($"Het getal was niet tussen {min} en {100}. Probeer opnieuw.");
                    }
                }
                catch
                {
                    Console.WriteLine(verkeerdeInput);
                }
            }
        }
    }
}