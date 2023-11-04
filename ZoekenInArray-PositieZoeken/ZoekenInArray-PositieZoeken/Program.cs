namespace ZoekenInArray_PositieZoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ZOEKEN IN ARRAY */

            string[] steden = { "Brussel", "Antwerpen", "Hasselt",
                    "Brugge", "Kortrijk", "Gent" };

            do
            {
                Console.Write("Stad?: ");
                string opTeZoekenStad = Console.ReadLine();

                int index = 0;
                bool gevonden = false;
                while (!gevonden && index < steden.Length)
                {
                    if (steden[index].ToLower() == opTeZoekenStad.ToLower())
                    {
                        gevonden = true;
                    }
                    else
                    {
                        index++;
                    }
                }

                if (gevonden)
                {
                    Console.WriteLine("De stad werd teruggevonden.");
                }
                else
                {
                    Console.WriteLine("De stad werd niet gevonden.");
                }
                Console.WriteLine();
            } while (true);

            /* POSITIE INDEX ZOEKEN ARRAY 

            int index = 0;
            bool gevonden = false;
            while (!gevonden && index < steden.Length)
            {
                if (steden[index].ToLower() == opTeZoekenStad.ToLower())
                {
                    gevonden = true;
                }
                else
                {
                    index++;
                }
            }

            if (gevonden)
            {
                Console.WriteLine($"De stad werd teruggevonden op index {index}.");*/
            }
        }
    }
}