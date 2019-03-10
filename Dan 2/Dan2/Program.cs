using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestZaposleni();
            TestVozila();
        }

        static void TestVozila()
        {
            Vozilo audi = new Vozilo("Audi", "A4", 2005, "NS 3245 JK", 220, 110);
            Vozilo bmw = new Vozilo("BMW", "320i", 2007, "BG 2093 NN", 215, 130);

            // ispis podataka
            audi.StampajPodatke();
            bmw.StampajPodatke();

            // uporedi audi sa bmw
            int rez = audi.PorediCene(bmw);
            string poruka = "";
            switch (rez)
            {
                case -1:
                    {
                        poruka = "Nas auto je jeftiniji :(";
                        break;
                    }
                case 0:
                    {
                        poruka = "Nas Audi ima istu vrednost kao drugi automobil";
                        break;
                    }
                case 1:
                    {
                        poruka = "Nas auto je skuplji od drugog automobila...";
                        break;
                    }
            }
            Console.WriteLine(poruka);

            Console.Write("-1 ako je prvo vozilo skuplje, 0 ako je vrednost jednaka, 1 ako je drugo vozilo skuplje");
            Console.WriteLine(Vozilo.PorediCene(audi, bmw));
        }

        static void TestZaposleni()
        {
            Zaposleni z1 = new Zaposleni("Dragan", "Milosevic", 12.6);
            Zaposleni z2 = new Zaposleni("Marija", "Markovic", 15);
            Zaposleni z3 = new Zaposleni("Tomica", "Zdravkovic", 23.5);

            int dani = 31;
                        
            z1.RacunajPlatu(dani);
            z2.RacunajPlatu(dani);
            z3.RacunajPlatu(dani);

            z1.StampajPlatu();
            z2.StampajPlatu();
            z3.StampajPlatu();

            Console.ReadLine();
        }
    }
}
