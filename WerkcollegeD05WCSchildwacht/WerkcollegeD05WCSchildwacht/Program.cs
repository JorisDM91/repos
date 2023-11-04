namespace WerkcollegeD05WCSchildwacht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool blijfHerhalen = true; // Schildwacht

            int nieuwGetal;
            int grootsteGetal = 0;
            int kleinsteGetal = 0;

            bool eerstGetalIngegeven = false;

            do
            {
                string input;

                Console.Write($"Geef getal in ('s' om te stoppen): ");
                input = Console.ReadLine();

                // input opkuisen
                input = input.ToLower();
                input = input.Trim();

                if (input == "s")
                {
                    blijfHerhalen = false;
                }
                else
                {
                    try
                    {
                        nieuwGetal = int.Parse(input);

                        if (eerstGetalIngegeven is false)
                        {
                            // De eerste keer dat een getal werd ingegeven.
                            grootsteGetal = nieuwGetal;
                            kleinsteGetal = nieuwGetal;
                        }
                        else
                        {
                            if (nieuwGetal > grootsteGetal)
                            {
                                grootsteGetal = nieuwGetal;
                            }

                            if (nieuwGetal < kleinsteGetal)
                            {
                                kleinsteGetal = nieuwGetal;
                            }
                        }

                        eerstGetalIngegeven = true;
                    }
                    catch
                    {
                        Console.WriteLine("Ongeldige input, geef opnieuw een getal in: ");
                        continue;
                    }
                }
            } while (blijfHerhalen);

            if (eerstGetalIngegeven is true)
            {
                Console.WriteLine($"Grootste getal = {grootsteGetal}.");
                Console.WriteLine($"Kleinste getal = {kleinsteGetal}.");
            }
            else
            {
                Console.WriteLine("Er werden geen geldige getallen ingevoerd.");
            }
        }
    }
}