namespace WerkcollegeD5D6oef14PatroonSterretjesDriehoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patroon C");
            int hoogte = 0;
            {
                for (int rij = 10; rij > hoogte; rij--)
                {   //deze code voegt altijd 1 sterretje toe
                    for (int kolom = 0; kolom < rij; kolom++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}