using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class krug : Objekat2D
    {
        double poluprecnik;

        public krug(double poluprecnik, string naziv = "Krug") : base(naziv)
        {
            Poluprecnik = poluprecnik;
        }

        public double Poluprecnik { get => poluprecnik; set => poluprecnik = value; }
        public override double Povrsina { get => poluprecnik * poluprecnik * Math.PI; }
        public override double Obim => 2 * poluprecnik * Math.PI;
        public override double Sirina => poluprecnik * 2;
        public override double Visina => Sirina;
    }
}
