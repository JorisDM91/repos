namespace D05somofverschil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            bool invoer;
            string bewerking = "";
            int totaal = 0;
            bool heeftBewerking = false;

            do
            {
                string getalOfOperatorAlsTekst = Console.ReadLine();

                if (getalOfOperatorAlsTekst == "+" || getalOfOperatorAlsTekst == "-")
                {
                    bewerking = getalOfOperatorAlsTekst;
                    heeftBewerking = true;
                    // + or - met volgende getal
                }
                else if (getalOfOperatorAlsTekst == "=") 
                {
                    Console.WriteLine($"{totaal}");
                    // = = toont de oplossing
                }    
                else
                {
                    invoer = int.TryParse(getalOfOperatorAlsTekst, out getal1);
                    if (heeftBewerking)
                    {
                        if (bewerking == "+")
                        {
                            totaal += getal1;
                        }
                        else if (bewerking == "-")
                        {
                            totaal -= getal1;
                        }
                    }
                    else
                    {
                        totaal = getal1;
                    }
                }

            } while (true);
        }
    }
}