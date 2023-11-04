using System.ComponentModel;

namespace ForWillekeurigGetalDelers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vraag

            // Vraag de gebruiker om een willekeurig positief geheel getal.
            // Zorg ervoor dat de gebruiker een correct getal ingeeft.
            // Ga na in code hoeveel delers dit getal heeft.
            // Een getal is een deler als de rest bij deling gelijk is aan nul.

            int getal;
            int aantalDelers = 0;

            // input van gebruiker
            do
            {
                Console.Write("Geef een positief geheel getal in: ");

                try
                {
                    getal = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Dit is geen geldig getal.");
                    continue;
                }

                if (getal <= 0) 
                {
                    Console.WriteLine("Het ingegeven getal moet positief zijn.");
                    continue;
                }

                break;

            } while (true);

            // Algoritme
            // Voor elk getal kleiner dan tien
            // -> herhalingslus
            for (int teller = 1; teller <= getal; teller++)
            {
                if (getal % teller == 0) 
                {
                    // teller is een deler
                    aantalDelers++;
                }
            }


            // output naar gebruiker
            Console.WriteLine($"Het getal {getal} heeft {aantalDelers} delers.");
        }
    }
}