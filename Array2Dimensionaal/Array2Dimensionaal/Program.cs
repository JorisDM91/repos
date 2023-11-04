namespace Array2Dimensionaal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Twee dimensionale array
            int[,] tabel = new int[10, 10];

            for (int rij = 0; rij < tabel.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < tabel.GetLength(1); kolom++)
                {
                    tabel[rij, kolom] = (rij + 1) * (kolom + 1);
                }
            }

            for (int rij = 0; rij < tabel.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < tabel.GetLength(1); kolom++)
                {
                    Console.Write(tabel[rij, kolom]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
        }
    }
}