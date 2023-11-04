namespace D07beginmethoofdletters
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
            else
            {
                int lengte = Math.Min(5, tekst.Length);
                string resultaat = tekst.Substring(0, lengte).ToUpper() + tekst.Substring(lengte);

                Console.WriteLine(resultaat);
            }
        }
    }
}