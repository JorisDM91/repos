using System.Dynamic;

namespace Getallen_opsplitsen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startGetal;
            

            // Vraag het getal aan de gebruiker
            Console.Write("Geef een getal in (>=999  en  <=9999) : ");
            startGetal = int.Parse(Console.ReadLine());

            //Algoritme
            int duizendtal;
            int honderdtal;
            int tiental;
            int eenheid;
            int rest;

            duizendtal = startGetal / 1000;
            rest = startGetal % 1000;

            honderdtal = rest / 100;
            rest = rest % 100;

            tiental = rest / 10;
            // rest = rest % 10; alternatieve manier
            rest %= 10;

            eenheid = rest;

            //Output

            Console.WriteLine(
             $"{duizendtal}\tduizendtallen\n" +
             $"{honderdtal}\thonderdtallen\n" +
             $"{tiental}\ttientallen\n" +
             $"{eenheid}\teenheden\n");





        }
    }
}