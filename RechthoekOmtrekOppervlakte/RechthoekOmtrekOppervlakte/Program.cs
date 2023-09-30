namespace RechthoekOmtrekOppervlakte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Omtrek en oppervlakte Rechthoek");
            double lengte;
            double breedte;
            Console.WriteLine("wat is de lengte ?");
            lengte = double.Parse(Console.ReadLine());
            Console.WriteLine("wat is de breedte ?");
            breedte = double.Parse(Console.ReadLine());
            double oppervlakte = lengte * breedte;
            Console.WriteLine($"de oppervlakte is {oppervlakte}");
            double omtrek = lengte * 2 + breedte * 2;
            Console.WriteLine($"de omtrek is {omtrek}");

        }
    }
}