using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chleb
{
    public class Ekran
    {
        public void WyswietlInstrukcje(string instrukcja)
        {
            Console.WriteLine($"Instrukcja: {instrukcja}");
        }

        public void WyswietlKomunikat(string komunikat)
        {
            Console.WriteLine($"Komunikat: {komunikat}");
        }
    }
}
