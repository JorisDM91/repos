namespace D07dotdotdot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();
            string tekstMetPunten = "";

            for (int i = 0; i < tekst.Length; i++)
            {
                tekstMetPunten += tekst[i];
                if (i < tekst.Length - 1)
                {
                    tekstMetPunten += ".";
                }
            }

            Console.WriteLine(tekstMetPunten);
        }
    }
}