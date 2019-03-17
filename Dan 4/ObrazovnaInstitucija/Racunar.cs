using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazovnaInstitucija
{
    class Racunar
    {
        string procesor;
        string memorija;
        string operativniSistem;

        public Racunar(string procesor, string memorija, string operativniSistem)
        {
            Procesor = procesor;
            Memorija = memorija;
            OperativniSistem = operativniSistem;
        }

        string Procesor { get => procesor; set => procesor = value; }
        string Memorija { get => memorija; set => memorija = value; }
        string OperativniSistem { get => operativniSistem; set => operativniSistem = value; }
    }
}
