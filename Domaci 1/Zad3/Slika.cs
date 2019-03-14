using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Slika : Fajl
    {
        int sirina;
        int visina;

        public Slika(string naziv, int sirina, int visina, int velicina, Folder parent)
            : base(naziv, velicina, parent)
        {
            Sirina = sirina;
            Visina = visina;
        }

        public int Sirina { get => sirina; private set => sirina = value; }
        public int Visina { get => visina; private set => visina = value; }
    }
}
