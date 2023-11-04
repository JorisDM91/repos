namespace D09maximumtemperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] meetwaarden = { 13.4, 12.1, 10.8, 10.8, 10.3, 8.9, 7.9, 7.8, 7.4, 7.2, 6.4, 9.7, 13.7, 17.2, 19.6, -9999.0, -9999.0, 22.4, 22.7, 22.8, 22.3, 18.4 };

            double minimumTemperatuur = double.MaxValue;
            double maximumTemperatuur = double.MinValue;

            foreach (double meetwaarde in meetwaarden)
            {
                if (meetwaarde != -9999.0)
                {
                    minimumTemperatuur = Math.Min(minimumTemperatuur, meetwaarde);
                    maximumTemperatuur = Math.Max(maximumTemperatuur, meetwaarde);
                }
            }

            if (minimumTemperatuur != double.MaxValue && maximumTemperatuur != double.MinValue)
            {
                Console.WriteLine($"Minimumtemperatuur: {minimumTemperatuur}");
                Console.WriteLine($"Maximumtemperatuur: {maximumTemperatuur}");
            }
            else
            {
                Console.WriteLine("Geen geldige meetwaarden beschikbaar.");
            }
        }
    }
}