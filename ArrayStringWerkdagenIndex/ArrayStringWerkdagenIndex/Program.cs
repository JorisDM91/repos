namespace ArrayStringWerkdagenIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] werkdagen = { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag" };

            int index;

            index = 0;
            Console.WriteLine(werkdagen[index]);

            index = 2;
            Console.WriteLine(werkdagen[index]);

            index = werkdagen.Length - 1;
            Console.WriteLine(werkdagen[index]);
        }
    }
}