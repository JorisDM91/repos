namespace D06somevenoneven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int evenGetal = 0;
            int onevenGetal = 0;
            int evenSom = 0;
            int onevenSom = 0;

            while (true)
            {
                Console.Write("Geef een getal (negatief om te stoppen): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int getal))
                {
                    if (getal < 0)
                    {
                        break;
                    }

                    if (getal % 2 == 0)
                    {
                        evenGetal++;
                        evenSom += getal;
                    }
                    else
                    {
                        onevenGetal++;
                        onevenSom += getal;
                    }
                }
            }

            Console.WriteLine($"{evenGetal} even getallen");
            Console.WriteLine($"{onevenGetal} oneven getallen");
            Console.WriteLine($"som van de even getallen is {evenSom}");
            Console.WriteLine($"som van de oneven getallen is {onevenSom}");
        }
    }
}