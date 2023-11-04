namespace D09dagnummernaarmaand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aantalDagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] maandNamen = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };

            Console.Write("Geef het dagnummer : ");
            int dagnummer = int.Parse(Console.ReadLine());

            if (dagnummer >= 1 && dagnummer <= 365)
            {
                int maandIndex = 0;

                while (dagnummer > aantalDagen[maandIndex])
                {
                    dagnummer -= aantalDagen[maandIndex];
                    maandIndex++;
                }

                string maand = maandNamen[maandIndex];
                Console.WriteLine($"De maand is {maand}.");
            }
            else
            {
                Console.WriteLine("De maand is onbepaald");
            }
        }
    }
}