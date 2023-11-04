namespace WerkcollegeD5_D6oef8.Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lees een afstand in als een geheel aantal kilometer. 
             * Moet strikt positief zijn! Controleer!
             * Druk een tabel af, bestaande uit drie kolommen. 
             * Kolom 1 bevat de afstand,kolom 2 bevat de snelheid,
             * variërend van 40 km/u, 50 km/u, 60 km/u tot en met 140 km/u. 
             * In de derde kolom staat de tijd (in uren en minuten) die nodig is 
             * om die afstand af te leggen aan die bepaalde snelheid.
             * Zorg voor een identiek geformatteerde uitvoer! */

                int afstand;

                Console.Write("Geef een afstand in kilometer (strikt positief):");
                if (int.TryParse(Console.ReadLine(), out afstand) 
                    &&
                    afstand > 0)
                {
                    // int snelheid begint bij 40 tem 140, in stappen van 10
                    for (int snelheid = 40; snelheid <= 140; snelheid += 10)
                    {
                        double tijdInUren = (double)afstand / snelheid;
                        int tijdInMinuten = (int)(tijdInUren * 60);

                        int uren = tijdInMinuten / 60;
                        int minuten = tijdInMinuten % 60;
                        
                        Console.WriteLine($"{afstand,3:D} km{snelheid,10:D} km/u{uren,8:D} u {minuten,3:D} min");
                    }
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Zorg ervoor dat de afstand een strikt positief getal is.");
                }

        }
    }
}