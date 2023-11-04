namespace PatronenSterretjes
{
    internal class Program
    {
        const int hoogte = 10;
        Console.WriteLine("Patroon A:");
        
        {
            for (int rij = 0; rij<hoogte; rij++)
            {
                for (int kolom = 0; kolom<rij + 1; kolom++)
                {
                    Console.Write("*");
                }
    Console.WriteLine();
            }
        }

        Console.WriteLine("Patroon B:");

{
    for (int rij = 0; rij < hoogte; rij++)
    {
        for (int kolom = 0; kolom < hoogte; kolom++)
        {
            if (kolom < rij)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Patroon C:");

for (int rij = 0; rij < hoogte; rij++)
{
    for (int kolom = 0; kolom < (hoogte - rij); kolom++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine("Patroon D:");

{
    for (int rij = hoogte - 1; rij >= 0; rij--)
    {
        for (int kolom = 0; kolom < hoogte; kolom++)
        {
            if (kolom < rij)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
}
    }
}