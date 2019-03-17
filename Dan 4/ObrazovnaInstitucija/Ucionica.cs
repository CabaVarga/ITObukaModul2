using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazovnaInstitucija
{
    class Ucionica
    {
        string broj;
        string naziv;
        Racunar[] racunari;

        public Ucionica(string naziv, string broj)
        {
            Broj = broj;
            Naziv = naziv;
            racunari = new Racunar[20];
            // inicijalizacija racunara
            for (int i = 0; i < 20; i++)
            {
                racunari[i] = new Racunar("Pentium 4", "4 GB", "Windows 7 Home");
            }
        }

        string Broj { get => broj; set => broj = value; }
        string Naziv { get => naziv; set => naziv = value; }
    }
}
