namespace D08dagentotaal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dagen = new int[12];

            dagen[0] = 31;
            dagen[1] = 28;
            dagen[2] = 31;
            dagen[3] = 30;
            dagen[4] = 31;
            dagen[5] = 30;
            dagen[6] = 31;
            dagen[7] = 31;
            dagen[8] = 30;
            dagen[9] = 31;
            dagen[10] = 30;
            dagen[11] = 31;

            int totaal = 0;

            for (int i = 0; i < dagen.Length; i++)
            {
                totaal += dagen[i];
            }

            Console.WriteLine("Totaal: " + totaal);

        }
    }
}