using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazovnaInstitucija
{
    class Osoba
    {
        string ime;
        string prezime;
        string jmbg;

        public Osoba(string ime, string prezime, string jmbg)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jmbg;
        }

        string Ime { get => ime; set => ime = value; }
        string Prezime { get => prezime; set => prezime = value; }
        string JMBG { get => jmbg; set => jmbg = value; }
    }
}
