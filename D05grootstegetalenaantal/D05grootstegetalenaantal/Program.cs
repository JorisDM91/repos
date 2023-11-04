namespace D05grootstegetalenaantal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            int teller = 0;
            int getal = 0;
            int grootsteGetal = int.MinValue;
            int aantal = 0;

            while (true)
            {
                Console.WriteLine("Voer een getal in (typ -1 om te stoppen) ");
                getal = int.Parse(Console.ReadLine());


                if (getal == -1)
                    break;

                if (getal > grootsteGetal)
                {
                    grootsteGetal = getal;
                    aantal = 1;
                }
                else if (getal == grootsteGetal)
                {
                    aantal++;
                }
            }
            
            if (grootsteGetal != int.MinValue)
            {
                Console.WriteLine($"Het grootste getal is: {grootsteGetal} ");
            }
                Console.WriteLine("Het aantal getallen is: " + aantal);
        }
    }
}