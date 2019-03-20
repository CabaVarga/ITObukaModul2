using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba01
{
    public class Ucionica
    {
        public Ucionica(string oznaka, int sprat)
        {
            Oznaka = oznaka;
            Sprat = sprat;
        }

        public string Oznaka { get; private set; }
        public int Sprat { get; private set; }
        public List<Racunar> Racunari { get; private set; }

        public void DodajRacunar(Racunar racunar)
        {
            Racunari.Add(racunar);
        }
    }
}