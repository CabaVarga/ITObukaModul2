using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Folder : Disk
    {
        Folder parent;
        protected DateTime datumKreiranja;
        protected DateTime datumPoslednjeIzmene;

        public Folder(string name, Folder parent = null) : base(name)
        {
            this.parent = parent;
            this.datumKreiranja = DateTime.Now;
        }
    }
}
