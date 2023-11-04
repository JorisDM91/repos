namespace SchermWissen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teller = 10;
            while (teller > 0)
            {
                Console.Clear();
                Console.Write(teller);
                teller--;
                System.Threading.Thread.Sleep(1000); // wacht 1 seconden
            }
            Console.Clear();
            Console.WriteLine("Start!");
        }
    }
}