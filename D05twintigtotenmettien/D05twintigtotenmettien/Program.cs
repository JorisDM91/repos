namespace D05twintigtotenmettien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Breng aan de hand van een do while statement 
             * alle even getallen van 20 tot en met 10 op de console.*/

            int evenGetal = 20;

            do
            {
                if (evenGetal % 2 == 0)
                {
                    Console.WriteLine(evenGetal);
                }
                evenGetal--;
            } while (evenGetal >= 10);
        }
    }
}