namespace D07aantalkeere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            int teller = 0;
            char gezochtKarakter = 'e';

            foreach (char karakter in tekst)
            {
                if (char.ToLower(karakter) == char.ToLower(gezochtKarakter))
                {
                    teller++;
                }
            }

            Console.WriteLine($"'{gezochtKarakter}' komt {teller} keer voor.");
        }
    }
}