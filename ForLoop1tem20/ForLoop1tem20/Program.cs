namespace ForLoop1tem20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // print met de for loop de even getallen
            // tot en met 20 op het scherm
            for (int teller=1; teller < 21; teller++)
            {
                if (teller % 2 == 0)
                { 
                Console.WriteLine(teller);
                }
                
            }
        }
    }
}