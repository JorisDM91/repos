namespace D04weerzonderlogischeoperatoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maak oefening D04weer opnieuw, 
             * maar vermijd voor deze oefening 
             * het gebruik van de && of || operatoren.*/

            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine();
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