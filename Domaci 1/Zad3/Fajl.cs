using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Fajl : Folder
    {
        int velicina;

        public Fajl(string naziv, int velicina, Folder parent) 
            : base(naziv, parent) { Velicina = velicina; }

        public int Velicina { get => velicina; private set => velicina = value; }
        


    }
}
