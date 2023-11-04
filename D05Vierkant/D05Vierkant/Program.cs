namespace D05Vierkant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lengte zijde?: ");
            int zijde = int.Parse(Console.ReadLine());

            for (int breedte = 0; breedte < zijde; breedte++)
            {
                for (int hoogte = 0; hoogte < zijde; hoogte++) 
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}