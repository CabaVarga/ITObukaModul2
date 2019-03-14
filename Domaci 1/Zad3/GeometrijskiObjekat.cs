using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class GeometrijskiObjekat
    {
        string naziv;

        public GeometrijskiObjekat(string naziv)
        {
            Naziv = naziv;
        }

        public string Naziv { get => naziv; private set => naziv = value; }
    }
}
