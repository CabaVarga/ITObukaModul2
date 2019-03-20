using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class Osoba
    {
        public Osoba(string ime, string prezime, string jmbg)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jmbg;
        }

        public virtual string PredstaviSe()
        {
            throw new System.NotImplementedException();
        }

        public string Ime { get; private set; }
        public string Prezime { get; private set; }
        public string JMBG { get; private set; }
    }
}