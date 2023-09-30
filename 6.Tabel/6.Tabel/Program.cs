namespace _6.Tabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal in");

            Console.WriteLine(
                $"{1,10:D}{10,10:D}{100,10:D}{1000,10:D}{10000,10:D}"
                );
            //Andere manier voor kolommen
            Console.WriteLine(
                $"{1,10:D}" +
                $"{10,10:D}" +
                $"{100,10:D}" +
                $"{1000,10:D}" +
                $"{10000,10:D}"
                );
        }
    }
}