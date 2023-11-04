namespace D06voorspeloutput
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /*a)*/ for (int i = 3; i < 9; i++) { Console.WriteLine(i); } // 3 4 5 6 7 8

            
           /*b)*/ for (int i = 4; i >= -3; i--) { Console.WriteLine(i); } // 4 3 2 1 -1 -2 -3

            
           /*c)*/ for (int i = 7; i != 15; i++) { Console.WriteLine(i); } // 7 8 9 10 11 12 13 14

            
           /*d)*/ for (int i = 6; i != 15; i += 2) { Console.WriteLine(i); } // 6 8 10 12 14

            
           /*e)*/ for (int i = 7; i != 15; i--) { Console.WriteLine(i); } // oneindig -1

            
           /*f)*/ for (int i = 20; i < 15; i++) { Console.WriteLine(i); } // geeft niets weer want initiële waarde is al groter dan de conditie

            
           /*g)*/ for (int i = 0; i < 16; i += 4) { Console.WriteLine(i); } // 0 4 8 12 

            
           /*h)*/ for (int i = 45; i < 1000; i *= 2) { Console.WriteLine(i); } // 45 90 180 360 720

            
           /*i)*/ for (int i = -5; i < 5; i += 3) { Console.WriteLine(i); } // -5 -2 1 4

        }
    }
}