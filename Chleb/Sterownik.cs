using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Chleb
{
    public class Sterownik
    {
        private static Sterownik _instance;

        public Ekran Ekran { get; private set; }
        public Waga Waga { get; private set; }
        public Mieszadlo Mieszadlo { get; private set; }
        public DyspenserDodatkow DyspenserDodatkow { get; private set; }

        private Sterownik()
        {
            Ekran = new Ekran();
            Waga = new Waga();
            Mieszadlo = new Mieszadlo();
            DyspenserDodatkow = new DyspenserDodatkow();
        }

        public static Sterownik GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Sterownik();
            }
            return _instance;
        }

        public void PiecChleb(Przepis przepis)
        {

            Ekran.WyswietlInstrukcje($"Dodaj {przepis.Maka} gram mąki");
            Waga.SprawdzWage(przepis.Maka);

            Ekran.WyswietlInstrukcje($"Dodaj {przepis.Woda} ml wody");
            Waga.SprawdzWage(przepis.Woda);

            Ekran.WyswietlInstrukcje($"Dodaj {przepis.Drozdze} gram drożdży");
            Waga.SprawdzWage(przepis.Drozdze);

            Ekran.WyswietlInstrukcje($"Dodaj {przepis.Sol} gram soli");
            Waga.SprawdzWage(przepis.Sol);

            bool dodatki = ZapytajDodatki();

            Ekran.WyswietlKomunikat("Rozpoczynam ugniatanie ciasta");
            Mieszadlo.Ugniataj(przepis.CzasUgniatania);

            Ekran.WyswietlKomunikat("Ciasto wyrasta");
            Wyrastaj(przepis.CzasWyrastania);

            if (dodatki)
            {
                Ekran.WyswietlKomunikat("Dodawanie dodatków");
                DyspenserDodatkow.DodajDodatki();
            }

            Ekran.WyswietlKomunikat($"Rozpoczynam pieczenie chleba w temperaturze {przepis.TemperaturaPieczenia} stopni Celsjusza");
            Piecz(przepis.CzasPieczenia, przepis.TemperaturaPieczenia);

            static bool ZapytajDodatki()
            {
                Console.WriteLine("Dodać dodatki? y/n");
                string dodatki = Console.ReadLine();
                bool dodajDodatki;

                switch (dodatki)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        ZapytajDodatki();
                        return true;

                }
            }
        }

        public void Wyrastaj(int czasWyrastania)
        {
            // Implementacja procesu wyrastania
            Console.WriteLine($"Wyrastanie ciasta przez {czasWyrastania} minut...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Wyrastanie zakończone.");
        }

        public void Piecz(int czasPieczenia, int temperatura)
        {
            // Implementacja procesu pieczenia
            Console.WriteLine($"Pieczenie chleba przez {czasPieczenia} minut w temperaturze {temperatura} stopni Celsjusza...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Chleb gotowy!");
        }

        public void Myj()
        {
            Console.WriteLine("Nalej wodę do połowy zbiornika i wlej trochę mydła.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Woda nalana. Rozpoczynam mycie zbiornika...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Procedura mycia zakończona!");
        }
    }
}