namespace D07tussenaccolades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            int openingAccoladeIndex = tekst.IndexOf('{');
            int sluitendeAccoladeIndex = tekst.IndexOf('}');

            if (openingAccoladeIndex != -1 && sluitendeAccoladeIndex != -1 && openingAccoladeIndex < sluitendeAccoladeIndex)
            {
                string deelTussenAccolades = tekst.Substring(openingAccoladeIndex + 1, sluitendeAccoladeIndex - openingAccoladeIndex - 1);
                Console.WriteLine("gevonden: " + deelTussenAccolades);
            }
            else
            {
                Console.WriteLine("niet gevonden");
            }
        }
    }
}