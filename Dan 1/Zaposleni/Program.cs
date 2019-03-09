using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaposleni
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposleni z1 = new Zaposleni();
            Zaposleni z2 = new Zaposleni();
            Zaposleni z3 = new Zaposleni();

            z1.PostaviImePrezime("Goran", "Markovic");
            z1.PostaviKoeficijent(32);
            z2.PostaviImePrezime("Marko", "Draganovic");
            z2.PostaviKoeficijent(35);
            z3.PostaviImePrezime("Dragana", "Novakovic");
            z3.PostaviKoeficijent(45);

            z1.StampajPlatu();
            z2.StampajPlatu();
            z3.StampajPlatu();
        }
    }
}
