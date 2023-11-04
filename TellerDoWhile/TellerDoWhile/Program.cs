namespace TellerDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoe oud wordt de jarige : ");
            int leeftijd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= leeftijd; i++)
            {
                Console.WriteLine("Hiep hiep hiep, hoera!");
            }
        }
    }
}