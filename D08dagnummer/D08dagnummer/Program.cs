namespace D08dagnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dagnummer?: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int dagnummer))
            {
                if (dagnummer >= 1 && dagnummer <= 7)
                {
                    string[] weekdagen = { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag" };
                    string weekdag = weekdagen[dagnummer -1];
                    Console.WriteLine($"Dagnummer {dagnummer} is {weekdag}.");
                }
                else
                {
                    Console.WriteLine("Dit is geen geldig dagnummer.");
                }
            }
        }
    }
}