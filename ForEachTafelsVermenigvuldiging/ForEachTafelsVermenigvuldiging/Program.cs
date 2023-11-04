namespace ForEachTafelsVermenigvuldiging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vraag

            // Druk de tafels van vermenigvuldiging af op het scherm.
            //
            // 1    2   3   4   5   6   7   8   9   10
            // 2    4   6   8   10  12  14  16  18  20
            // 3    6   9   12  15  18  21  24  27  30
            // ....
            // 12   24  36  48  60  72  84  96  108 120

            // Nested for loop
            for (int rijNr = 1; rijNr <= 20; rijNr++)
            {
                for (int kolomNr = 1; kolomNr <= 10; kolomNr++)
                {
                    Console.Write($"\t{rijNr * kolomNr}");
                }
                Console.WriteLine();
            }
        }
    }
}