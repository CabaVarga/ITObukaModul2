using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Disk
    {
        Folder root;
        string naziv;
        int kapacitet;
        int zauzeto;

        public Disk(string naziv, Folder root = null, int kapacitet = 0)
        {
            this.naziv = naziv;
            this.root = root;
            this.kapacitet = kapacitet;
        }

        public Folder Root { get => root; private set => root = value; }
    }
}
