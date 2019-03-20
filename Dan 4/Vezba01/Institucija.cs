using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class Institucija
    {
        
        public Institucija(string naziv, string adresa)
        {
            
            Ucionice = new List<Ucionica>();
            Kadrovi = new List<Zaposleni>();
            Naziv = naziv;
            Adresa = adresa;
        }
        public string Naziv { get; private set; }
        public string Adresa { get; private set; }
        public List<Zaposleni> Kadrovi { get; private set; }
        public List<Ucionica> Ucionice { get; private set; }

        public void DodajZaposlenog(Zaposleni zaposleni)
        {
            Kadrovi.Add(zaposleni);
        }

        public void DodajUcionicu(Ucionica ucionica)
        {
            Ucionice.Add(ucionica);
        }
    }
}