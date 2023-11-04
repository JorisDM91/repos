namespace D07klinkersenmedeklinkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string klinkers = "aeiou";
            string medeklinkers = "bcdfghjklmnpqrstvwxyz";

            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine().ToLower();

            int aantalKlinkers = 0;
            int aantalMedeklinkers = 0;

            foreach (char karakter in tekst)
            {
                if (klinkers.Contains(karakter.ToString()))
                {
                    aantalKlinkers++;
                }
                else if (medeklinkers.Contains(karakter.ToString()))
                {
                    aantalMedeklinkers++;
                }
            }

            Console.WriteLine($"{aantalKlinkers} klinker(s) en {aantalMedeklinkers} medeklinker(s)");
        }
    }
}