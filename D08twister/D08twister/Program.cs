namespace D08twister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het spel start over 3 seconden...");
            Thread.Sleep(3000);

            string[] lichaamsdelen = { "linkerhand", "rechterhand", "linkervoet", "rechtervoet" };
            string[] kleuren = { "rood", "groen", "geel", "blauw" };
            Random random = new Random();

            while (true)
            {
                string lichaamsdeel = lichaamsdelen[random.Next(lichaamsdelen.Length)];
                string kleur = kleuren[random.Next(kleuren.Length)];

                Console.WriteLine($"{lichaamsdeel} op {kleur}");
                Thread.Sleep(7000);
            }
        }
    }
}