namespace D09toongetallenmetjoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = { 4, 7, 9, 34, 2, 56, 34, 78 };

            string resultaat = string.Join(", ", getallen);

            Console.WriteLine(resultaat);
        }
    }
}