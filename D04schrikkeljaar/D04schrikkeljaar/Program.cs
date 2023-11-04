namespace D04schrikkeljaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maak een programma dat van een ingevoerd jaartal op de console brengt 
             * of het gaat om een schrikkeljaar of niet.
                Een schrikkeljaar is een jaar dat deelbaar is door 4 
                en niet door 100, of deelbaar is door 400.*/

            Console.WriteLine("Geef een jaartal: ");
            int jaartal = Int32.Parse(Console.ReadLine());

            if ((jaartal % 4 == 0 && jaartal % 100 != 0 ) || jaartal % 400 == 0) 
            
            {
                Console.WriteLine($"{jaartal} is een schrikkeljaar.");
            }
            else
            {
                Console.WriteLine($"{jaartal} is geen schrikkeljaar.");
            }
        }
    }
}