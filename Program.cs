namespace EvidenceVlacky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpravaVlacky sprava = new SpravaVlacky();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Evidence Vláčků");
            Console.WriteLine("-----------------------------------");

            bool bezi = true;
            while (bezi)
            {
                Console.WriteLine();
                Console.WriteLine("Vyberte možnost:");
                Console.WriteLine("1 - Přidat nový modýlek");
                Console.WriteLine("2 - Vypsat všechny modýlky");
                Console.WriteLine("3 - Vyhledat modýlek");
                Console.WriteLine("4 - Ukončit");

                int volba;
                if (int.TryParse(Console.ReadLine(), out volba))
                {
                    switch (volba)
                    {
                        case 1:
                            sprava.PridatNovyModel();
                            break;
                        case 2:
                            sprava.ZobrazitVsechnyModely();
                            break;
                        case 3:
                            sprava.HledatModel();
                            break;
                        case 4:
                            bezi = false;
                            break;
                        default:
                            Console.WriteLine("Neplatná volba.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Neplatná volba.");
                }
            }

            Console.WriteLine("Konec programu.");
        }
    }

}