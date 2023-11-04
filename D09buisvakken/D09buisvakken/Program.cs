namespace D09buisvakken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };

            Console.WriteLine("Buisvakken (onvoldoendes): ");

            for (int i = 0; i < vakken.Length; i++)
            {
                if (scores[i] < 50)
                {
                    Console.WriteLine($"{vakken[i]}: {scores[i]}");
                }
            }
        }
    }
}