namespace PartialArrayInvoegenVerwijderen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[10];
            int aantalGetallen;

            getallen[0] = 1;
            getallen[1] = 2;
            getallen[2] = 3;
            getallen[3] = 4;
            getallen[4] = 5;
            getallen[5] = 6;

            aantalGetallen = 6;

            int inTeVoegenGetal = 7;
            int inTeVoegenIndex = 2;

            // Voeg het extra inTeVoegenGetal toe op index 2
            // Voor invoegen: 1 2 3  -> aantalGetallen == 3
            // Na invoegen: 1 2 7 3  -> aantalGetallen == 4

            for (int i = aantalGetallen - 1; i >= inTeVoegenIndex; i--)
            {
                getallen[i + 1] = getallen[i];
            }

            getallen[inTeVoegenIndex] = inTeVoegenGetal;

            aantalGetallen++;

            // Verwijder een getal uit de array op index 2

            int teVerwijderenIndex = 2;

            for (int i = teVerwijderenIndex; i < aantalGetallen - 1; i++)
            {
                getallen[i] = getallen[i + 1];
            }

            aantalGetallen--;
        }
    }
}