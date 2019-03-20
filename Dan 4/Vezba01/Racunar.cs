using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class Racunar
    {
        public Racunar(int inventar, string opis)
        {
            InventarskiBroj = inventar;
            Model = opis;
        }

        public int InventarskiBroj { get; private set; }
        public string Model { get; private set; }
    }
}