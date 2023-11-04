namespace D05grootstegetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker meermaals om een getal vraagt 
             * (totdat de gebruiker een -1 ingeeft). 
             * Voor de eenvoud gaan we er hier van uit dat de gebruiker netjes getallen invoert, 
             * je hoeft hier niet op te controleren.
             Na afloop toont het programma wat het GROOTSTE GETAL was van alle getallen 
             (de ingegeven -1 telt niet mee). */

            int totaal = 0;
            int teller = 0;
            int getal = 0;
            int grootsteGetal = int.MinValue;

            while (true)
            {
                Console.WriteLine("Voer een getal in (typ -1 om te stoppen) ");
                getal = int.Parse(Console.ReadLine());

                if (getal == -1)
                    break;

                if (getal > grootsteGetal) 
                {
                grootsteGetal = getal;
                }
            }

            if (grootsteGetal != int.MinValue) 
            {
                Console.WriteLine($"Het grootste getal is: {grootsteGetal} ");
            }
        }
    }
}