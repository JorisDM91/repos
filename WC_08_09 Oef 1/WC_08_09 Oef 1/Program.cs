namespace WC_08_09_Oef_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // WC_08_09 Oef 1
            const int AantalGetallen = 10;

            int[] getallen = new int[AantalGetallen];
            int index;

            for (index = 0; index < getallen.Length; index++)
            {
                int getal;
                Console.Write($"Geef getal {index + 1} in: ");
                try
                {
                    getal = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Onjuiste input. Probeer opnieuw.");
                    index--;
                    continue;
                }

                getallen[index] = getal;
            }

            int extraGetal;

            while (true)
            {
                Console.Write("Geef nog een extra getal in: ");
                try
                {
                    extraGetal = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ongeldig extra getal. Probeer opnieuw.");
                    continue;
                }
                break;
            }

            bool[] getallenGroterDanExtra = new bool[AantalGetallen];
            Array.Fill(getallenGroterDanExtra, false);

            for (index = 0; index < getallen.Length; index++)
            {
                if (getallen[index] > extraGetal)
                {
                    getallenGroterDanExtra[index] = true;
                }
            }

            Console.WriteLine("Index    Waarde");
            for (index = 0; index < getallen.Length; index++)
            {
                if (getallenGroterDanExtra[index] is true)
                {
                    Console.WriteLine($"{index,5}   {getallen[index],6}");
                }
            }
        }
    }
}