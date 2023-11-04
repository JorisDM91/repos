namespace ForAlleLettersAlfabet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Console.WriteLine(letter);
            }  
            Console.ReadKey();// verwijderd onderste info
        }
    }
}