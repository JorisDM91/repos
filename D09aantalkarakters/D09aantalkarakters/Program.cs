namespace D09aantalkarakters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] woorden;

            woorden = new string[] { "dit", "zijn", "een", "aantal", "woorden", "die", "ik", "gebruik", "voor", "dit", "programma" };

            int[] aantalKarakters = new int[woorden.Length];
            int totaalKarakters = 0;

            for (int i = 0; i < woorden.Length; i++)
            {
                totaalKarakters += woorden[i].Length;
                aantalKarakters[i] = totaalKarakters;
            }

            Console.WriteLine(string.Join(',', aantalKarakters));
        }
    }
}