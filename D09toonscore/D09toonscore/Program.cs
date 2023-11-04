namespace D09toonscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };

            Console.Write("Geef de naam van een vak: ");
            string ingevoerdVak = Console.ReadLine().ToLower();

            int index = -1;

            for (int i = 0; i < vakken.Length; i++)
            {
                if (vakken[i].ToLower() == ingevoerdVak)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine($"De score voor dit vak is {scores[index]}/100");
            }
            else
            {
                Console.WriteLine("Geen score bekend.");
            }
        }
    }
}