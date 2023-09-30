namespace Oefening_D01euronaarpound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double euroBedrag = 105.4;

            // bekijk of je nog variabelen ontbreekt (nog variabelen moet declareren)
            
            double poundBedragWissel = euroBedrag * 0.88 ;
            string poundBedrag = poundBedragWissel.ToString("F3");

            // ken de juiste waardes toe aan alle variabelen,
            // eventueel gebaseerd op de juist formule

            Console.Write(euroBedrag);
            Console.Write("EUR = ");
            Console.Write(poundBedrag);
            Console.Write("GPB");
        }
    }
}