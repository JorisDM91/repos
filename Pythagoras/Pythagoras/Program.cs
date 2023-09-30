using System;
namespace Pythagoras;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Voer de breedte van de driehoek in: ");
        double breedte = Convert.ToDouble(Console.ReadLine());

        Console.Write("Voer de hoogte van de driehoek in: ");
        double hoogte = Convert.ToDouble(Console.ReadLine());

        Console.Write("Voer de lengte van de schuine zijde in: ");
        double schuineZijde = Convert.ToDouble(Console.ReadLine());

        bool isRechthoekig = IsRechthoekigeDriehoek(breedte, hoogte, schuineZijde);

        if (isRechthoekig)
        {
            Console.WriteLine("Het is een rechthoekige driehoek.");
        }
        else
        {
            Console.WriteLine("Het is geen rechthoekige driehoek.");
        }

        Console.ReadLine();
    }

    static bool IsRechthoekigeDriehoek(double breedte, double hoogte, double schuineZijde)
    {
        double zijde1 = Math.Min(breedte, hoogte);
        double zijde2 = Math.Max(breedte, hoogte);

        double hypoVergelijking = Math.Pow(zijde1, 2) + Math.Pow(zijde2, 2);

        return Math.Abs(Math.Pow(schuineZijde, 2) - hypoVergelijking) < double.Epsilon;
    }
}
