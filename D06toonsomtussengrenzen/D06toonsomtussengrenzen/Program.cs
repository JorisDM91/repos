namespace D06toonsomtussengrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Geef de ondergrens: ");
                int ondergrens = int.Parse(Console.ReadLine());
                Console.WriteLine("Geef de bovengrens: ");
                int bovengrens = int.Parse(Console.ReadLine());

                int som = 0;
                int huidigGetal = ondergrens + 1;

                string uitvoer = "";

                do
                {
                    som += huidigGetal;
                    uitvoer += huidigGetal + " + ";
                    huidigGetal++;
                }
                while (huidigGetal < bovengrens);

                if (uitvoer.Length > 0)
                {
                    uitvoer = uitvoer.Remove(uitvoer.Length - 2); // Verwijder de laatste " + "
                }

                Console.WriteLine($"{uitvoer} = {som}");
            }
        }
    }
}