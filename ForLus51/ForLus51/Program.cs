namespace ForLus51
{
    internal class Program
    {
        static void Main(string[] args)
        {
        for (int i = 51; i > 0; i--) 
            {   // ongeheel getal = modulo = rest 0
                if (i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}