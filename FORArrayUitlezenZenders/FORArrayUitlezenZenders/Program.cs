namespace FORArrayUitlezenZenders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zenders = new string[4];
            zenders[0] = "mozaïek";
            zenders[1] = "Eén";
            zenders[2] = "Canvas/Ketnet";
            zenders[3] = "VTM";

            for (int index = 0; index < zenders.Length; index++)
            {
                Console.WriteLine(zenders[index]);
            }
            int[] veelvouden = new int[10];
            int veelvoud = 5;


            /* Veelvouden */

            // opvullen:
            for (int index = 0; index < veelvouden.Length; index++)
            {
                veelvouden[index] = veelvoud;
                veelvoud += 5;
            }

            // afdrukken:
            for (int index = 0; index < veelvouden.Length; index++)
            {
                Console.Write(veelvouden[index] + " ");
            }

            /* FOREACH */

            string[] woorden = { "dit", "is", "een", "test" };

            foreach (string woord in woorden)
            {
                Console.WriteLine(woord + " ");
            }

            /* Dynamische Array */

            Console.Write("Start getal?: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Eind getal?: ");
            int eind = int.Parse(Console.ReadLine());

            int aantalGetallen = eind - start + 1;

            if (aantalGetallen > 0)
            {
                // aanmaken
                int[] getallen = new int[aantalGetallen];

                // opvullen
                int getal = start;
                for (int index = 0; index < getallen.Length; index++)
                {
                    getallen[index] = getal;
                    getal++;
                }

                // afdrukken
                foreach (int element in getallen)
                {
                    Console.Write($"{element} ");
                }
            }
        }
    }
}