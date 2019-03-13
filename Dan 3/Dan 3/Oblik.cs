using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Oblik
    {
        String boja;
        String tip;
        int brojStrana;
        double povrsina;

        public Oblik() { }

        public Oblik(string boja, string tip, int brojStrana)
        {
            this.boja = boja;
            this.tip = tip;
            this.brojStrana = brojStrana;
        }

        public string Boja { get; set; }
        public string Tip { get; set; }
        public int BrojStrana { get; set; }
        public double Povrsina { get; set; }

        public void PromeniBoju(string boja)
        {
            this.boja = boja;
        }

        public void StampajPodatke()
        {
            Console.WriteLine("Ja sam {0}, boja mi je {1} i strana imam {2} :D", tip, boja, brojStrana);
            Console.WriteLine("Imam ogrooomnu povrsinu ... {0:F2} !!", Povrsina);
        }
    }
}
