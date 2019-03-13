using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Motocikl : Vozilo
    {
        string registracija;
        int brojSedista;

        public Motocikl(string marka, string tip, int godinaProizvodnje, int godinaRegistracije,
            int snaga, int kubikaza, Osoba vlasnik, string registracija, int brojSedista) : base(marka, tip,
              godinaProizvodnje, godinaRegistracije, snaga, kubikaza, vlasnik)
        {

        }
    }
}
