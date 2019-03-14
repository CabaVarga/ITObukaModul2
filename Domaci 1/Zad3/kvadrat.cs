using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class kvadrat : Objekat2D
    {
        double duzinaStranica;

        public kvadrat(double duzinaStranica, string naziv = "Kvadrat") : base(naziv)
        {
            DuzinaStranica = duzinaStranica;
        }

        public double DuzinaStranica { get => duzinaStranica; set => duzinaStranica = value; }
        public override double Povrsina { get => duzinaStranica * duzinaStranica; }
        public override double Obim => 4 * duzinaStranica;
        public override double Sirina => duzinaStranica;
        public override double Visina => duzinaStranica;
    }
}
