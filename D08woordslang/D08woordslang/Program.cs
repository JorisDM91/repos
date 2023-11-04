namespace D08woordslang
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] woorden = new string[5];

            for (int i = 0; i < woorden.Length; i++)
            {
                Console.Write("Geef een woord: ");
                woorden[i] = Console.ReadLine();
            }

            string woordslang = woorden[0];

            for (int i = 1; i < woorden.Length; i++)
            {
                if (woordslang.EndsWith(woorden[i][0].ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    woordslang += "-" + woorden[i];
                }
                else
                {
                    Console.WriteLine("Het is geen woordslang: " + woordslang);
                    return;
                }
            }

            Console.WriteLine("De woordslang is: " + woordslang);
        }
    }
}