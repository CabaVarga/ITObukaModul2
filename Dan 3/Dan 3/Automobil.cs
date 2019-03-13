using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Automobil : Vozilo
    {
        string registracija;
        int brojVrata;

        public Automobil(string marka, string tip, int godinaProizvodnje, int godinaRegistracije,
            int snaga, int kubikaza, Osoba vlasnik, string registracija, int brojVrata) : base(marka, tip,
              godinaProizvodnje, godinaRegistracije, snaga, kubikaza, vlasnik)
        {
            this.registracija = registracija;
            this.brojVrata = brojVrata;
        }

        public void StampajPodatke()
        {
            Console.WriteLine("Auto");
        }
    }
}
