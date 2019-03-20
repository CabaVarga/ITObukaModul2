using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class Asistent : Zaposleni
    {
        public Asistent(string ime, string prezime, string jmbg, Nastavnik mentor, int godinaDoktorskihStudija)
            : base(ime, prezime, jmbg)
        {
            Mentor = mentor;
            GodinaDoktorskihStudija = godinaDoktorskihStudija;
        }

        public Nastavnik Mentor { get; private set; }
        public int GodinaDoktorskihStudija { get; private set; }

        public override double RacunajPlatu()
        {
            return 40000 + GodinaDoktorskihStudija * 2000;
        }

        public override string PredstaviSe()
        {
            return "Ja sam " + Ime + " " + Prezime + ", asistent kod " + Mentor.Zvanje + " " + Mentor.Ime + " " +
                Mentor.Prezime + ", na " + GodinaDoktorskihStudija + ". godini doktorskih studija";
        }
    }
}