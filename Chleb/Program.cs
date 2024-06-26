using System;

namespace Chleb
{
    public class Program
    {

        public static void Main()
        {

            List<Przepis> przepisy = new List<Przepis>();
            przepisy.Add(new Przepis("pszenny", 450, 250, 15, 2, 10, 120, 30, 250));
            int option;
            Sterownik sterownik = Sterownik.GetInstance();

            while (true)
            {
                Console.Write("Wybierz opcje:" +
                    "\n 1. Upiecz chleb" +
                    "\n 2. Włącz program mycia" +
                    "\n 3. Dodaj przepis\n");
                while (true)
                {
                    try { option = Convert.ToInt16(Console.ReadLine()); break; }
                    catch { Console.WriteLine("Zła opcja!"); }
                }


                switch (option)
                {
                    case 1:
                        Console.WriteLine("Mamy następujące chleby: ");
                        foreach (Przepis przepis in przepisy)
                        {
                            Console.WriteLine(przepis.Nazwa);
                        }
                        Console.Write("Jaki chleb chcesz upiec?: ");
                        string chleb = Console.ReadLine();

                        if (
                            !przepisy
                            .Select(przepis => przepis.Nazwa)
                            .ToList().
                            Contains(chleb))
                        {
                            Console.WriteLine($"Nie ma takiego chleba jak {chleb}!");
                            continue;
                        }

                        sterownik.PiecChleb(przepisy.FirstOrDefault(przepis => przepis.Nazwa == chleb));

                        break;
                    case 2:
                        sterownik.Myj();
                        continue;
                        break;
                    case 3:
                        przepisy.Add(StworzPrzepis());
                        Console.WriteLine("Dodano przepis");
                        continue;
                        break;
                    default:
                        Console.WriteLine("Wybrano zły numer!");
                        Main();
                        break;


                }
            }
        }

        public static Przepis StworzPrzepis()
        {
            Console.WriteLine("Podaj nazwę przepisu:");
            string nazwa = Console.ReadLine();

            Console.WriteLine("Podaj ilość mąki (w gramach):");
            int maka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ilość wody (w ml):");
            int woda = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ilość drożdży (w gramach):");
            int drozdze = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ilość soli (w gramach):");
            int sol = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj czas ugniatania (w minutach):");
            int czasUgniatania = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj czas wyrastania (w minutach):");
            int czasWyrastania = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj czas pieczenia (w minutach):");
            int czasPieczenia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj temperaturę pieczenia (w stopniach Celsjusza):");
            int temperaturaPieczenia = Convert.ToInt32(Console.ReadLine());

            Przepis nowyPrzepis = new Przepis(nazwa, maka, woda, drozdze, sol, czasUgniatania, czasWyrastania, czasPieczenia, temperaturaPieczenia);
            return nowyPrzepis;
        }
    }
}