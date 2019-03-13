using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    public class Osoba
    {
        protected String ime;
        protected String prezime;
        protected int starost;

        Osoba() { }

        protected Osoba(String ime, String prezime, int starost)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.starost = starost;
        }



        public void PredstaviSe()
        {
            Console.WriteLine("Zovem se {0} {1} i imam {2} godina.",  ime, prezime, starost);
        }

    }
}
