using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class pravougaonik : Objekat2D
    {
        double stranicaA;
        double stranicaB;

        public pravougaonik(double stranicaA, double stranicaB, string naziv = "Pravougaonik")
            : base(naziv)
        {
            StranicaA = stranicaA;
            StranicaB = stranicaB;
        }

        public double StranicaA { get => stranicaA; set => stranicaA = value; }
        public double StranicaB { get => stranicaB; set => stranicaB = value; }
        public override double Povrsina { get => StranicaA * StranicaB; }
        public override double Obim => 2 * StranicaA + 2 * StranicaB;
        public override double Sirina => (StranicaA > StranicaB) ? StranicaA : StranicaB;
        public override double Visina => (StranicaA > StranicaB) ? StranicaB : StranicaA;
    }
}
