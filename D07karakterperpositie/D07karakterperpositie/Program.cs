namespace D07karakterperpositie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            for (int i = 0; i < tekst.Length; i++)
            {
                char karakter = tekst[i];
                Console.WriteLine($"{i} = {karakter}");
            }
        }
    }
}