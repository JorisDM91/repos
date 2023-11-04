namespace D08netto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] kortingen = { 10, 50, 19.4 };
            double brutoBedrag = 1000;

            double nettoBedrag = brutoBedrag;

            foreach (double korting in kortingen)
            {
                nettoBedrag -= korting;
            }

            Console.Write("Netto bedrag: " + nettoBedrag);
        }
    }
}