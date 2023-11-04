namespace D5DriehoekFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rechthoekzijde?: ");
            int zijde = int.Parse(Console.ReadLine());

            for (int breedte = 0; breedte < zijde; breedte++)
            {
                for (int hoogte = breedte; hoogte < zijde; hoogte++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }
    }
}