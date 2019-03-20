using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class NenastavniRadnik : Zaposleni
    {
        public NenastavniRadnik(string ime, string prezime, string jmbg, string radnoMesto, int godineStaza)
            : base(ime, prezime, jmbg)
        {
            RadnoMesto = radnoMesto;
            GodineStaza = godineStaza;
        }

        public string RadnoMesto { get; private set; }
        public int GodineStaza { get; private set; }

        public override double RacunajPlatu()
        {
            return 30000 + GodineStaza * 500;
        }

        public override string PredstaviSe()
        {
            return "Ja sam " + Ime + " " + Prezime + ", radim kao " + RadnoMesto + " i imam radni staz " +
                GodineStaza + " godina.";
        }
    }
}