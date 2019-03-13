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
            TestZaposleni();
        }

        static void TestZaposleni()
        {
            Zaposleni z1 = new Zaposleni("Milan", "Markovic", 35, 23);
            Zaposleni z2 = new Zaposleni("Marija", "Vuksanovic", 28, 15);
            Zaposleni z3 = new Zaposleni("Dusan", "Nikcevic", 42, 31);

            z1.RacunajPlatu(24); z1.StampajPlatu();
            z2.RacunajPlatu(24); z2.StampajPlatu();
            z3.RacunajPlatu(25); z3.StampajPlatu();
        }
    }
}
