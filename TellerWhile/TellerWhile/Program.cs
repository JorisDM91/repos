namespace TellerWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teller = 1; // initialisatie

            while (teller <6) // conditie
            {
                Console.WriteLine(teller); // statement
                teller++; // update conditie
            }

            // for statement (zolang iets waar is)
            // for (<initialisatie>; <boolean expression> ; <update conditie>)
            //{
            // <statement>
            //}
            for (int tellerFor = 1; 
                     tellerFor < 6; 
                     tellerFor++)
            {
                Console.WriteLine(tellerFor); // statement
            }
        }
    }
}