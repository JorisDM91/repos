namespace D05reeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1?: ");
            int getal1;
            bool invoerOk;
            do
            {
                string getalAlsTekst = Console.ReadLine();
                invoerOk = int.TryParse(getalAlsTekst, out getal1);
                if (!invoerOk)
                {
                    Console.Write("Gelieve een geheel getal in te voeren, getal 1?: ");
                }
            } while (!invoerOk);

            Console.Write("Getal 2?: ");
            int getal2;
            do
            {
                string getalAlsTekst = Console.ReadLine();
                invoerOk = int.TryParse(getalAlsTekst, out getal2);
                if (!invoerOk)
                {
                    Console.Write("Gelieve een geheel getal in te voeren, getal 2?: ");
                }
            } while (!invoerOk);

            if (getal1 > getal2)
            {
                int temp = getal1;
                getal1 = getal2;
                getal2 = temp;
                
            }

            Console.Write("Reeks van klein naar groot: ");

            int teller = getal1;

            do
            {
                Console.Write($"{teller} ");
                teller++;

            } while (teller <= getal2);
            
        }
    }
}