using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan2
{
    class Vozilo
    {
        string marka;
        string tip;
        int godiste;
        string registracija;
        int maksBrzina;
        int snaga;

        public Vozilo() { }

        public Vozilo(string m, string t, int g, string r, int max, int s)
        {
            this.marka = m;
            this.tip = t;
            this.godiste = g;
            this.registracija = r;
            this.maksBrzina = max;
            this.snaga = s;
        }

        public double Vrednost()
        {
            return maksBrzina * snaga / (2017 - (double)godiste);
        }

        public void StampajPodatke()
        {
            Console.WriteLine("MARKA: {0}\nTIP: {1}\nGODISTE: {2}\nREGISTRACIJA: {3}", marka, tip, godiste, registracija);
            Console.WriteLine("MAKSIMALNA BRZINA: {0} km/h", maksBrzina);
            Console.WriteLine("SNAGA: {0} KS\nVREDNOST: {1:C2}\n", snaga, Vrednost());
        }

        public int PorediCene(Vozilo v)
        {
            double v1 = Vrednost();
            double v2 = v.Vrednost();

            if (v1 == v2)
            {
                return 0;
            }
            else if (v1 < v2)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public static int PorediCene(Vozilo v1 ,Vozilo v2)
        {
            double vr1 = v1.Vrednost();
            double vr2 = v2.Vrednost();

            if (vr1 == vr2)
            {
                return 0;
            }
            else if (vr1 < vr2)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
