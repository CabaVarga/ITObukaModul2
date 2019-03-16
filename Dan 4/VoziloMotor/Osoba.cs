using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoziloMotor
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

        public string PribaviIme() { return this.ime; }
        public string PribaviPrezime() { return this.prezime; }

        public void PredstaviSe()
        {
            Console.WriteLine(String.Format(
            "Ime: {0}, Prezime: {1}, Starost: {2} godina",
            this.ime, this.prezime, this.starost));
        }
    }
}
