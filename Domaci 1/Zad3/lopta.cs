using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class lopta : Objekat3D
    {
        double poluprecnik;

        public lopta(double poluprecnik, string naziv = "Lopta") : base(naziv)
        {
            Poluprecnik = poluprecnik;
        }

        public double Poluprecnik { get => poluprecnik; set => poluprecnik = value; }
        public override double Povrsina { get => 4 * poluprecnik * poluprecnik * Math.PI; }
        public override double Zapremina => Povrsina * poluprecnik / 3;
        public override double Sirina => poluprecnik * 2;
        public override double Visina => Sirina;
    }
}
