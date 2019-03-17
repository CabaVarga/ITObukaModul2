using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazovnaInstitucija
{
    class Zaposleni : Osoba
    {
        string pozicija;

        public Zaposleni(string ime, string prezime, string jmbg, string pozicija)
            : base(ime, prezime, jmbg)
        {
            Pozicija = pozicija;
        }

        public string Pozicija { get => pozicija; set => pozicija = value; }
    }
}
