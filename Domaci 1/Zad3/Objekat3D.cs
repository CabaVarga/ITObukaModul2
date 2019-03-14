using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Objekat3D : GeometrijskiObjekat
    {
        // hmmm 3D objekat ima povrsinu, sirinu i visinu (+ zapreminu i dubinu) ali nema obim
        // da li naslediti od Objekat2D ili iz GeometrijskiObjekat
        double povrsina;
        double zapremina;
        double sirina;
        double visina;
        double dubina;

        public Objekat3D(string naziv = "3D Objekat") : base(naziv) { }

        public virtual double Povrsina { get; }
        public virtual double Zapremina { get; }
        public virtual double Sirina { get; }
        public virtual double Visina { get; }
        public virtual double Dubina { get; }
    }
}
