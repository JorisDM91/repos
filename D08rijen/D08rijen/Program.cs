namespace D08rijen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] getallen = new double[6];
            int count = 0;

            while (count < 6)
            {
                Console.Write("Geef een getal (leeg laten om te stoppen): ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                if (double.TryParse(input, out double getal))
                {
                    getallen[count] = getal;
                    count++;
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
                }
            }

            if (count < 3)
            {
                Console.WriteLine("Er zijn te weinig getallen ingevoerd voor een analyse.");
            }
            else
            {
                if (IsRekenkundigeRij(getallen, count))
                {
                    double delta = getallen[1] - getallen[0];
                    Console.WriteLine($"Dit is een rekenkundige rij met delta {delta}");
                }
                else if (IsMeetkundigeRij(getallen, count))
                {
                    double factor = getallen[1] / getallen[0];
                    Console.WriteLine($"Dit is een meetkundige rij met factor {factor}");
                }
                else
                {
                    Console.WriteLine("Dit is een gewone rij");
                }
            }
        }

        static bool IsRekenkundigeRij(double[] getallen, int count)
        {
            if (count < 3)
                return false;

            double delta = getallen[1] - getallen[0];

            for (int i = 2; i < count; i++)
            {
                if (getallen[i] - getallen[i - 1] != delta)
                    return false;
            }

            return true;
        }

        static bool IsMeetkundigeRij(double[] getallen, int count)
        {
            if (count < 3)
                return false;

            double factor = getallen[1] / getallen[0];

            for (int i = 2; i < count; i++)
            {
                if (getallen[i] / getallen[i - 1] != factor)
                    return false;
            }

            return true;
        }
    }
}