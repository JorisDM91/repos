namespace D04weermetrobuusteinvoer
{
    internal class Program
    {
        static void Main(string[] args)
        {   // zonder operatoren
            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine().Trim().ToLower();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine().Trim().ToLower();
            bool hetRegent = (regen == "ja");

            if (deZonSchijnt)
            {
                if (hetRegent) 
                { 
                Console.WriteLine("Regenboog.");
                }
            }
            else if (hetRegent)
            {
                Console.WriteLine("Slecht weer.");
            }
            else if (deZonSchijnt)
            {
                Console.WriteLine("Mooi weer.");
            }
            else
            {
                Console.WriteLine("Saaie dag.");
            }
        }
    }
}