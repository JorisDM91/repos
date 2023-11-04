namespace ArrayPositieZoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };

            Console.WriteLine("Geef een waarde in om te zoeken: ");
            int waarde = int.Parse(Console.ReadLine());
            bool gevonden = false;

            Console.WriteLine("Gevonden posities: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == waarde)
                {
                    Console.Write(i + " ");
                    gevonden = true;
                }
            }
            if (!gevonden)
            {
                Console.WriteLine("De waarde werd niet gevonden in de array. ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}