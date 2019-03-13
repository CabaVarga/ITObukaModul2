using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestZaposleni();
            // TestKlijent();
            // TestVozila();
            TestOblika();
        }

        static void TestOblika()
        {
            Krug kr1 = new Krug("crvena", "krug", 1, 4);
            Kvadrat kv1 = new Kvadrat("plava", "kvadrat", 4, 3.14);

            kr1.StampajPodatke();
            kv1.StampajPodatke();

            Console.WriteLine("--- Menjamo boju kvadrata ---");
            kv1.PromeniBoju("zuta");
            kv1.StampajPodatke();
        }

        static void TestVozila()
        {
            Student s1 = new Student("Marko", "Markovic", 42, 345, 11, 11);
            Zaposleni z1 = new Zaposleni("Darija", "Milosevic", 32, 32);
            Automobil auto = new Automobil("BMW", "E320", 2009, 2015, 123, 2022, s1, "NS 324 HK", 2);

            auto.StampajPodatke();
            StampajVozilo(auto);
            var auto2 = (Vozilo)auto;
            auto2.StampajPodatke();

            Console.WriteLine();

            Vozilo v = new Automobil("Mercedes", "A180", 2009, 2018, 100, 1300, z1, "BG 877 HH", 4);
            v.StampajPodatke();
        }

        static void StampajVozilo(Vozilo voz)
        {
            voz.StampajPodatke();
        }

        static void TestKlijent()
        {
            Klijent kl1 = new Klijent("Marko", "Markovic", 42, 103455);
            Klijent kl2 = new Klijent("Dario", "Ciric", 34, 102834);

            kl1.Uplati(10000);
            kl2.Uplati(10000);

            Console.WriteLine("--- Pre transfera ---");

            kl1.StampajStanje();
            kl2.StampajStanje();
            kl1.Prenesi(kl2, 5000);

            Console.WriteLine("--- Nakon transfera ---");
            kl1.StampajStanje();
            kl2.StampajStanje();
        }

        static void TestZaposleni()
        {
            Zaposleni z1 = new Zaposleni("Milan", "Markovic", 35, 23);
            Zaposleni z2 = new Zaposleni("Marija", "Vuksanovic", 28, 15);
            Zaposleni z3 = new Zaposleni("Dusan", "Nikcevic", 42, 31);

            z1.RacunajPlatu(24); z1.StampajPlatu();
            z2.RacunajPlatu(24); z2.StampajPlatu();
            z3.RacunajPlatu(25); z3.StampajPlatu();

            Student s1 = new Student("Marko", "Markovic", 32, 423, 73, 85);
            s1.StampajPoene();
        }
    }
}
