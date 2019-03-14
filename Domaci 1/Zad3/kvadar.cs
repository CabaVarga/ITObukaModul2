using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class kvadar : Objekat3D
    {
        double stranicaA;
        double stranicaB;
        double stranicaC;

        public kvadar(double stranicaA, double stranicaB, double stranicaC, string naziv = "Kvadar")
            : base(naziv)
        {
            StranicaA = stranicaA;
            StranicaB = stranicaB;
            StranicaC = stranicaC;
        }

        public double StranicaA { get => stranicaA; set => stranicaA = value; }
        public double StranicaB { get => stranicaB; set => stranicaB = value; }
        public double StranicaC { get => stranicaC; set => stranicaC = value; }
        public override double Povrsina
        {
            get
            {
                pravougaonik pu1 = new pravougaonik(StranicaA, StranicaB);
                pravougaonik pu2 = new pravougaonik(StranicaB, StranicaC);
                pravougaonik pu3 = new pravougaonik(StranicaA, StranicaC);

                return 2 * pu1.Povrsina + 2 * pu2.Povrsina + 2 * pu3.Povrsina;
            }

        }
        public override double Zapremina { get => StranicaA * StranicaB * StranicaC; }
        public override double Sirina { get => StranicaA; }
        public override double Visina { get => StranicaB; }
        public override double Dubina { get => StranicaC; }
    }
}
