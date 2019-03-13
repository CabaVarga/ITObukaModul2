using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Klijent : Osoba
    {
        int racun;
        double stanje;

        public Klijent(string ime, string prezime, int starost, int racun) : base(ime, prezime, starost)
        {
            this.racun = racun;
        }

        public void StampajStanje()
        {
            Console.WriteLine("{0} {1} na racunu {2} ima na raspolaganju {3:C2}", ime, prezime, racun, stanje);
        }

        public void PromeniStanje(double iznos)
        {
            this.stanje += iznos;
        }

        public void Uplati(double iznos)
        {
            stanje += iznos;
        }

        public void Prenesi(Klijent klijent, double iznos)
        {
            stanje -= iznos;
            klijent.PromeniStanje(iznos);
        }

    }
}
