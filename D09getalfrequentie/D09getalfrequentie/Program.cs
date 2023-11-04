namespace D09getalfrequentie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] frequenties = new int[11];

            while (true)
            {
                Console.Write("Geef een getal in [0,10] (of 'stop' om te eindigen): ");
                string invoer = Console.ReadLine().ToLower();

                if (invoer == "stop")
                    break;

                if (int.TryParse(invoer, out int getal) && getal >= 0 && getal <= 10)
                {
                    frequenties[getal]++;
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Voer een getal tussen 0 en 10 in of 'stop' om te eindigen.");
                }
            }

            for (int i = 0; i <= 10; i++)
            {
                if (frequenties[i] > 0)
                {
                    Console.WriteLine($"{i} kwam {frequenties[i]} keer voor");
                }
            }
        }
    }
}