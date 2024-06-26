using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chleb
{
    public class Przepis
    {
        public string Nazwa { get; set; }
        public int Maka { get; set; } // w gramach
        public int Woda { get; set; } // w ml
        public int Drozdze { get; set; } // w gramach
        public int Sol { get; set; } // w gramach
        public int CzasUgniatania { get; set; } // w sekundach
        public int CzasWyrastania { get; set; } // w sekundach
        public int CzasPieczenia { get; set; } // w sekundach
        public int TemperaturaPieczenia { get; set; } // w stopniach Celsjusza

        public Przepis(string nazwa, int maka, int woda, int drozdze, int sol, int czasUgniatania, int czasWyrastania, int czasPieczenia, int temperaturaPieczenia)
        {
            Nazwa = nazwa;
            Maka = maka;
            Woda = woda;
            Drozdze = drozdze;
            Sol = sol;
            CzasUgniatania = czasUgniatania;
            CzasWyrastania = czasWyrastania;
            CzasPieczenia = czasPieczenia;
            TemperaturaPieczenia = temperaturaPieczenia;
        }
    }
}


