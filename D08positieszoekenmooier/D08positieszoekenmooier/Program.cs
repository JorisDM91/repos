namespace D08positieszoekenmooier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };

            Console.Write("Voer een waarde in om te zoeken: ");
            int waarde = int.Parse(Console.ReadLine());

            bool gevonden = false;
            Console.Write($"Waarde {waarde} gevonden op positie(s): ");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == waarde)
                {
                    Console.Write(i + " ");
                    gevonden = true;
                }
            }

            if (gevonden)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("waarde niet gevonden. ");
            }
        }
    }
}