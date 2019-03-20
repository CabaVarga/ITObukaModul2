using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class Nastavnik : Zaposleni
    {
        public Nastavnik(string ime, string prezime, string jmbg, string zvanje, int brojSCIRadova)
            : base(ime, prezime, jmbg)
        {
            Zvanje = zvanje;
            BrojSCIRadova = brojSCIRadova;
        }

        public string Zvanje { get; private set; }
        public int BrojSCIRadova { get; private set; }

        public override double RacunajPlatu()
        {
            return 60000 + BrojSCIRadova * 3000;
        }

        public override string PredstaviSe()
        {
            return "Ja sam " + Zvanje + " " + Ime + " " + Prezime + " i imam " +
                BrojSCIRadova + " objavljenih radova.";
        }
    }
}