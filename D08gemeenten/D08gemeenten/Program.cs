namespace D08gemeenten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gemeenten = new string[8];

            gemeenten[0] = "Brussel";
            gemeenten[1] = "1000";
            gemeenten[2] = "Antwerpen";
            gemeenten[3] = "2000";
            gemeenten[4] = "Brugge";
            gemeenten[5] = "8000";
            gemeenten[6] = "Gent";
            gemeenten[7] = "9000";

            for (int i = 1; i < gemeenten.Length; i += 2)
            {
                Console.WriteLine(gemeenten[i]);
            }
        }
    }
}