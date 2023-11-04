using System;

namespace WC_0809_Oef6_Euromillions.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WC_08_09 Oef 6: Euromillions

            const int AantalGetallen = 5;
            const int MaxBereikGetallen = 50;
            const int MaxBereikSterren = 12;
            const int AantalSterren = 2;

            int[] getrokkenGetallen = new int[AantalGetallen];
            int[] getrokkenSterren = new int[AantalSterren];
            string[] bestaandeSterrenbeelden = { "Ram", "Leeuw", "Boogschutter", "Stier", "Maagd", "Steenbok", "Tweelingen", "Weegschaal", "Waterman", "Kreeft", "Schorpioen", "Vissen" };


            Random random = new Random();

            for (int i = 0; i < getrokkenGetallen.Length; i++)
            {
                while (true)
                {
                    int getrokkenGetal = random.Next(1, MaxBereikGetallen + 1);

                    if (Array.IndexOf(getrokkenGetallen, getrokkenGetal) >= 0)
                    {
                        continue;
                    }
                    getrokkenGetallen[i] = getrokkenGetal;
                    break;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                while (true)
                {
                    int getrokkenSter = random.Next(1, MaxBereikSterren + 1);

                    if (Array.IndexOf(getrokkenSterren, getrokkenSter) >= 0)
                    {
                        continue;
                    }
                    getrokkenSterren[i] = getrokkenSter;
                    break;
                }
            }

            int indexSterrenbeeld = random.Next(0, bestaandeSterrenbeelden.Length);
            string getrokkenSterrenbeeld = bestaandeSterrenbeelden[indexSterrenbeeld];

            Array.Sort(getrokkenGetallen);
            Array.Sort(getrokkenSterren);

            Console.WriteLine($"De getallen zijn: [{String.Join(", ", getrokkenGetallen)}]");

            Console.WriteLine($"De sterren [{String.Join(", ", getrokkenSterren)}]");

            Console.WriteLine($"Het sterrenbeeld = {getrokkenSterrenbeeld}");


        }
    }
}