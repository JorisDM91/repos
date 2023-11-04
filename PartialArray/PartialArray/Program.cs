namespace PartialArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laat de gebruiker max. 100 getallen ingeven,
            // maar hij dient er niet perse 100 in te geven.
            // 
            // De gebruiker kan stoppen met getallen in te geven
            // met het karakter 's'.
            //
            // Nadien worden alle ingegeven karakters in omgekeerde
            // volgorde (LIFO) op het scherm getoond.

            int[] getallen = new int[100];
            int aantalGetallen = 0;

            while (aantalGetallen < 100)
            {
                Console.Write("Voer een getal in of druk op 's' om te stoppen: ");
                string invoer = Console.ReadLine();

                if (invoer == "s")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(invoer, out int getal))
                    {
                        getallen[aantalGetallen] = getal;
                        aantalGetallen++;
                    }
                    else
                    {
                        Console.WriteLine("Dit is geen geldig getal. Probeer het opnieuw.");
                    }
                }
            }

            Console.WriteLine("De getallen in omgekeerde volgorde: ");
            for (int i = aantalGetallen - 1; i >= 0; i--)
            {
                Console.WriteLine(getallen[i]);
            }

        }
    }
}