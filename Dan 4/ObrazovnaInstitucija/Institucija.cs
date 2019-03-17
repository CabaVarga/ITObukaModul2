using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazovnaInstitucija
{
    class Institucija
    {
        Ucionica[] ucionice;
        int brojacUcionica;
        Zaposleni[] zaposleni;
        string naziv;

        public Institucija(string naziv)
        {
            ucionice = new Ucionica[20];
            zaposleni = new Zaposleni[20];
            Naziv = naziv;
        }

        public string Naziv { get => naziv; set => naziv = value; }

        public void DodajUcionicu(string naziv, string broj)
        {
            ucionice[brojacUcionica] = new Ucionica(naziv, broj);
            brojacUcionica++;
        }

        public void RegistrujUcionicu(Ucionica ucionica)
        {
            ucionice[brojacUcionica] = ucionica;
            brojacUcionica++;
        }
    }
}
