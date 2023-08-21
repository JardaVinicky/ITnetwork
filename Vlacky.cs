using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceVlacky
{
    internal class Vlacky
    {
        public string Skupina { get; }
        public string Typ { get; }
        public string KatCislo { get; }
        public int Cena { get; }

        public Vlacky(string skupina, string typ, string katCislo, int cena)
        {
            Skupina = skupina;
            Typ = typ;
            KatCislo = katCislo;
            Cena = cena;
        }

        public string FormatovaneInformace()
        {
            return "Skupina: " + Skupina + ", Typ: " + Typ + ", Kat. číslo: " + KatCislo + ", Cena: " + Cena;
        }
    }
}
