using System.Security.Cryptography.X509Certificates;

namespace MethodOefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        { }

        // Schrijf een methode die het aantal delers van een positief getal
        // berekent en teruggeeft in een lijst.



        public static List<int> GeefDelers(int positiefGetal)
        {
            List<int> delers = new List<int>();
            if (positiefGetal < 0) 
            {
             throw new ArgumentOutOfRangeException(nameof(positiefGetal), "Getal moet positief zijn.");
            }

        }
    }
}