using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaposleni
{
    class Zaposleni
    {
        string ime;
        string prezime;
        double koefRadnogMesta;

        public void PostaviImePrezime(string i, string p)
        {
            ime = i;
            prezime = p;
        }

        public void PostaviKoeficijent(double koef)
        {
            koefRadnogMesta = koef;
        }

        public double IzracunajPlatu()
        {
            double plata = koefRadnogMesta * 2500;
            return plata;
        }

        public void StampajPlatu()
        {
            Console.WriteLine("Zaposleni {0} {1} ima platu = {2:C}", ime, prezime, IzracunajPlatu());
        }
    }
}
