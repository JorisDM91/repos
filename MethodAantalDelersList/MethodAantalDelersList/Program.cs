namespace MethodAantalDelersList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een methode die het aantal delers van een positief getal
            // berekent en teruggeeft in een lijst.

            List<int> delers;

            delers = GeefDelers(10);

            Console.WriteLine("De delers van 10 zijn: "); // 2, 5
            SchrijfLijstNaarScherm(delers);
            Console.WriteLine();
            Console.WriteLine();


            // Schrijf een methode die een karakter een aantal keer op het scherm
            // gaat afdrukken. De methode krijgt het karakter binnen en het aantal keer.




            // Schrijf een methode die elk karakter van een string een aantal keer op 
            // het scherm gaat afdrukken. De methode krijgt de string binnen en het aantal keer.
            // abc -> aaabbbccc

            DrukStringAf("abc", 5);
        }

        public static void DrukKarakterAf(char ingegevenKarakter, int aantalKeer)  // (Methode vraag 2)
        {
            for (int teller = 0; teller < aantalKeer; teller++)
            {
                Console.Write(ingegevenKarakter);
            }
        }

        public static void DrukStringAf(string ingegevenString, int aantalKeer)
        {
            foreach (char c in ingegevenString)
            {
                DrukKarakterAf(c, aantalKeer);
            }
        }

        public static List<int> GeefDelers(int positiefGetal)
        {
            List<int> list = new List<int>();

            if (positiefGetal < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(positiefGetal), "Getal moet positief zijn.");
            }

            int aantalDelers = 0;

            for (int delers = 1; delers <= positiefGetal; delers++)
            {
                if (positiefGetal % delers == 0)
                {
                    list.Add(delers);
                }
            }

            return list;
        }

        public static void SchrijfLijstNaarScherm(List<int> list)
        {
            // String.Join
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(list[i]);
            }
        }
    }
}