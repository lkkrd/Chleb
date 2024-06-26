using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chleb
{
    public class Mieszadlo
    {
        public void Ugniataj(int czasUgniatania)
        {
            Console.WriteLine($"Ugniatanie ciasta przez {czasUgniatania} minut...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Ugniatanie zakończone.");
        }
    }
}
