namespace Oefening_D01totalebedrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biljettenVan10Euro = 7;
            int biljettenVan5Euro = 6;
            int muntstukkenVan2Euro = 5;
            int muntstukkenVan1Euro = 4;
            int muntstukkenVan50Cent = 3;

            // bereken het totale bedrag, en schrijf die weg in een nieuwe variabele

            double totaleBedrag =

                biljettenVan10Euro * 10 +
                biljettenVan5Euro * 5 +
                muntstukkenVan2Euro * 2 +
                muntstukkenVan1Euro * 1 +
                muntstukkenVan50Cent * 0.5;

            // druk hier de inhoud van deze variabele af op de console

            Console.WriteLine($"Het totale bedrag is : {totaleBedrag}");




        }
    }
}