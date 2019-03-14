using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Objekat2D : GeometrijskiObjekat
    {
        double obim;
        double povrsina;
        double sirina;
        double visina;

        public Objekat2D(string naziv = "2D Objekat") : base(naziv) { }

        // da bi mogli proslediti objekte kao Objekat2D a da se vide i pozivaju odgovarajuce
        // metode pojedinih tipova, moramo definisati u nadklasi metode kao virtuelne
        // a u podklasi odgovarajuce metode oznaciti sa override
        public virtual double Obim { get; }
        public virtual double Povrsina { get; }
        public virtual double Sirina { get; }
        public virtual double Visina { get; }
    }
}
