using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class kocka : Objekat3D
    {
        double duzinaStranica;

        public kocka(double duzinaStranica, string naziv = "Kocka")
            : base(naziv)
        {
            DuzinaStranica = duzinaStranica;
        }

        public double DuzinaStranica { get => duzinaStranica; set => duzinaStranica = value; }
        public override double Povrsina
        {
            get
            {
                kvadrat kv = new kvadrat(duzinaStranica);
                return 6 * kv.Povrsina;
            }

        }
        public override double Zapremina { get => duzinaStranica * duzinaStranica * duzinaStranica; }
        public override double Sirina { get => duzinaStranica; }
        public override double Visina { get => duzinaStranica; }
        public override double Dubina { get => duzinaStranica; }
    }
}
