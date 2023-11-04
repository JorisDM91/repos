namespace D07bevatleesteken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            bool bevatLeesteken = false;

            foreach (char karakter in tekst)
            {
                if (char.IsPunctuation(karakter))
                {
                    bevatLeesteken = true;
                    break;
                }
            }

            if (bevatLeesteken)
            {
                Console.WriteLine("De tekst bevat minstens 1 leesteken.");
            }
            else
            {
                Console.WriteLine("De tekst bevat geen enkel leesteken.");
            }
        }
    }
}