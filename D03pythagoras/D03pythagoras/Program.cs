namespace D03pythagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat de lengte van de schuine zijde berekent van een rechthoekige driehoek.
            // Het programma vraagt de gebruiker om de basis en de hoogte van de driehoek(beiden kommagetallen)
            // en toont dan de lengte van de schuine zijde.
            // De lengte van die schuine zijde kun je berekenen met de stelling van Pythagoras, je kunt hier een voorbeeld uitproberen.
            // Een uitvoering met basis 3 en hoogte 4 :

            // Geef de basis: 3
            // Geef de hoogte: 4
            // De lengte van de schuine zijde is 5

            Console.WriteLine("Geef de basis van de driehoek: ");
            double basis = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geef de hoogte van de driehoek: ");
            double hoogte = Convert.ToDouble(Console.ReadLine());

            double schuineZ = Math.Sqrt(basis * basis + hoogte * hoogte);
            double afgerondeSchuineZ = Math.Round(schuineZ, 2);

            Console.WriteLine($"De lengte van de schuine zijde is {afgerondeSchuineZ}");

        }
    }
}