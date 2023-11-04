namespace D04prijsappels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker vraagt hoeveel kilo appels hij wenst aan te kopen. 
             * Druk vervolgens de prijs af. 
             * De prijs bedraagt 3 euro per kilo, of 2,5 euro indien minstens 10 kilo wordt afgenomen, 
             * 2 euro bij een minimum aankoop van 20 kilo.

               Voorbeeld programmaverloop (indien 17 wordt ingevoerd)…​

               Aantal kilo aan te kopen appels?: 17
               Prijs: 42,5 */

            Console.WriteLine("Hoeveel kg appelen wenst u aan te kopen?");
            double kgAppels = double.Parse(Console.ReadLine());

            double prijsKG = 3.0;

            if (kgAppels >= 10) 
            {
                prijsKG = 2.5;
            }
            if (kgAppels >= 20) 
            {
                prijsKG = 2.0;
            }

            double totalePrijs = prijsKG * kgAppels;

            Console.WriteLine("De prijs: " + totalePrijs + " euro");

        }
    }
}