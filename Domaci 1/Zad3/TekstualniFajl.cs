using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class TekstualniFajl : Fajl
    {
        string format;  // npr ASCII, UTF-8 itd

        public TekstualniFajl(string naziv, string format, int velicina, Folder parent)
            : base(naziv, velicina, parent)
        {
            Format = format;
        }

        public string Format { get => format; private set => format = value; }
    }
}
