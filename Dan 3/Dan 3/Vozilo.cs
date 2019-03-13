using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Vozilo
    {
        string marka;
        string tip;
        int godinaProizvodnje;
        int godinaRegistracije;
        int snaga;
        int kubikaza;
        Osoba vlasnik;

        public Vozilo(string marka, string tip, int godinaProizvodnje, int godinaRegistracije,
            int snaga, int kubikaza, Osoba vlasnik)
        {
            this.marka = marka;
            this.tip = tip;
            this.godinaProizvodnje = godinaProizvodnje;
            this.godinaRegistracije = godinaRegistracije;
            this.snaga = snaga;
            this.kubikaza = kubikaza;
            this.vlasnik = vlasnik;
        }

        public void StampajPodatke()
        {
            Console.WriteLine("Vozilo");
        }

        public virtual void PrenesiVlasnistvo(Osoba osoba)
        {
            this.vlasnik = osoba;
        }
    }
}
