using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Video : Fajl
    {
        TimeSpan duzina;

        public Video(string naziv, TimeSpan duzina, int velicina, Folder parent)
            : base(naziv, velicina, parent)
        {
            Duzina = duzina;
        }

        public TimeSpan Duzina { get => duzina; private set => duzina = value; }
    }
}
