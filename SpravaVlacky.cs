using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceVlacky
{
    internal class SpravaVlacky
    {
        private List<Vlacky> seznamVlacku;
        public SpravaVlacky()
        {
            seznamVlacku = new List<Vlacky>();
        }

        public void PridatNovyModel()
        {
            Console.WriteLine("Zadej skupinu: (např. lokomotiva, osobní vůz, nákladní vůz, ...)");
            string skupina = Console.ReadLine();
            Console.WriteLine("Zadej typ: (např. rychlíkáč, cisterna, plošiňák, ...)");
            string typ = Console.ReadLine();
            Console.WriteLine("Zadej katalogové číslo výrobce: ");
            string katCislo = Console.ReadLine();
            Console.WriteLine("Zadej cenu: ");
            int cena = int.Parse(Console.ReadLine());

            Vlacky novyModel = new Vlacky(skupina, typ, katCislo, cena);
            seznamVlacku.Add(novyModel);

            Console.WriteLine("Data byla uložena. Stiskněte libovolnou klávesu pro pokračování...");
            Console.ReadKey();
        }

        public void ZobrazitVsechnyModely()
        {
            Console.WriteLine();
            foreach (Vlacky model in seznamVlacku)
            {
                Console.WriteLine(model.FormatovaneInformace());
            }
            Console.WriteLine();
            Console.WriteLine("Stiskněte libovolnou klávesu pro pokračování...");
            Console.ReadKey();
        }

        public void HledatModel()
        {
            Console.WriteLine("Zadej skupinu: ");
            string skupina = Console.ReadLine();
            Console.WriteLine("Zadej typ: ");
            string typ = Console.ReadLine();

            Vlacky nalezenModel = seznamVlacku.Find(model => model.Skupina == skupina && model.Typ == typ);

            if (nalezenModel != null)
            {
                Console.WriteLine();
                Console.WriteLine(nalezenModel.FormatovaneInformace());
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Vláček nenalezen.");
            }

            Console.WriteLine();
            Console.WriteLine("Stiskněte libovolnou klávesu pro pokračování...");
            Console.ReadKey();
        }
    }
}
