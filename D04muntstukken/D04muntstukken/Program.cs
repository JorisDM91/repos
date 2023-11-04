namespace D04muntstukken
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Maak gebruik van de debugger om in te schatten waar het foutloopt,
            // en wat er foutloopt. Corrigeer dan ook de code op gepaste wijze.
            int muntstukkenVan2Euro;
            Console.Write("Aantal muntstukken van 2 euro?: ");
            muntstukkenVan2Euro = int.Parse(Console.ReadLine());

            int muntstukkenVan1Euro;
            Console.Write("Aantal muntstukken van 1 euro?: ");
            muntstukkenVan1Euro = int.Parse(Console.ReadLine());

            int muntstukkenVan50Cent;
            Console.Write("Aantal muntstukken van 50 eurocent?: ");
            muntstukkenVan50Cent = int.Parse(Console.ReadLine());

            double totaalBedrag = muntstukkenVan2Euro * 2;
            totaalBedrag += muntstukkenVan1Euro;
            totaalBedrag += muntstukkenVan50Cent * 0.5;

            string formuleAlsTekst = $"{muntstukkenVan2Euro} x 2 + ";
            formuleAlsTekst += $"{muntstukkenVan1Euro} x 1 + ";
            formuleAlsTekst += $"{muntstukkenVan50Cent} x 0.5";

            Console.WriteLine($"{formuleAlsTekst} = {totaalBedrag} euro");

        }
    }
}