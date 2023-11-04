namespace D07achterstevoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            char[] omgekeerdeTekstArray = new char[tekst.Length];

            for (int i = 0; i < tekst.Length; i++)
            {
                omgekeerdeTekstArray[i] = tekst[tekst.Length - 1 - i];
            }

            string omgekeerdeTekst = new string(omgekeerdeTekstArray);

            Console.WriteLine(omgekeerdeTekst);
        }
    }
}