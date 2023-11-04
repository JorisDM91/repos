namespace D08arrayopvullen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[9];

            // opvullen
            getallen[0] = 101;
            getallen[1] = 102;
            getallen[2] = 103;
            getallen[3] = 104;
            getallen[4] = 105;
            getallen[5] = 106;
            getallen[6] = 107;
            getallen[7] = 108;
            getallen[8] = 109;

            // afdrukken
            for (int index = 0; index < getallen.Length; index++)
            {
                Console.Write(getallen[index] + " ");
            }
        }
    }
}