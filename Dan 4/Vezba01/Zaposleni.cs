using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class Zaposleni : Osoba
    {
        public Zaposleni(string ime, string prezime, string jmbg) : base(ime, prezime, jmbg) { }

        public virtual double RacunajPlatu()
        {
            throw new System.NotImplementedException();
        }
    }
}