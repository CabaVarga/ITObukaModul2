using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Bojler
    {
        public double ZeljenaVrednost { get; set; }
        public double TrenutnaVrednost { get; set; }
        public bool StanjeTermostata { get; set; }
    }

    class UpravljanjeBojlerom
    {
        public UpravljanjeBojlerom(Bojler b)
        {
            Upravljam = b;
        }

        public Bojler Upravljam { get; set; }
    }
}
