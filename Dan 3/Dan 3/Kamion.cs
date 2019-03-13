using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Kamion : Vozilo
    {
        string registracija;
        int prenosivost;

        public Kamion(string marka, string tip, int godinaProizvodnje, int godinaRegistracije,
            int snaga, int kubikaza, Osoba vlasnik, string registracija, int prenosivost) : base(marka, tip,
              godinaProizvodnje, godinaRegistracije, snaga, kubikaza, vlasnik)
        {

        }
    }
}
