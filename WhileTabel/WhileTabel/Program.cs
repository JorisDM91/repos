namespace WhileTabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int AantalKolommen = 4;
            const int AantalRijen = 5;

            for (int kolom = 0; kolom < AantalKolommen; kolom++)
            {
                int resultaat = (int)(Math.Pow(10, kolom));

                string headerTekst;

                if (resultaat == 1)
                    headerTekst = $"N";
                else
                    headerTekst = $"{resultaat}*N";

                Console.Write(headerTekst);

                for (int i = headerTekst.Length; i < 10; i++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

            for (int rij = 0; rij < AantalRijen; rij++)
            {
                for (int kolom = 0; kolom < AantalKolommen; kolom++)
                {
                    int resultaat = (int)((rij + 1) * Math.Pow(10, kolom));

                    Console.Write($"{resultaat,-10:D}");
                }
                Console.WriteLine();
            }
        }
    }
}