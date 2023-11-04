namespace Werkcollege_D05_vraag_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            while (count <= 10)
            {
                Console.WriteLine(count % 2 == 1 ? "****" : "++++++++");
                count++;
                
            }
        }
    }
}