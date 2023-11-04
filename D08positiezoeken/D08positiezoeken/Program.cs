namespace D08positiezoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };

            Console.Write("Voer een waarde in om te zoeken: ");
            int waarde = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == waarde)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(); // Voeg een nieuwe regel toe na het tonen van de indexen.
        }
    }
}