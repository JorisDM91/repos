namespace D05rechthoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoogte?: ");
            int hoogte = int.Parse(Console.ReadLine());

            Console.Write("Breedte?: ");
            int breedte = int.Parse(Console.ReadLine());

            for (int breedteTeller = 0; breedteTeller < hoogte; breedteTeller++)
            {
                for (int hoogteTeller = 0; hoogteTeller < breedte; hoogteTeller++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}