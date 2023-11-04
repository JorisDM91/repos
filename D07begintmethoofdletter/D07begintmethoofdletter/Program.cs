namespace D07begintmethoofdletter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(tekst))
            {
                Console.WriteLine("De tekst is leeg.");
            }
            else if (char.IsUpper(tekst[0]))
            {
                Console.WriteLine("De tekst start met een hoofdletter.");
            }
            else if (char.IsLower(tekst[0]))
            {
                Console.WriteLine("De tekst start met een kleine letter.");
            }
            else
            {
                Console.WriteLine("De tekst begint niet met een letter.");
            }
        }
    }
}