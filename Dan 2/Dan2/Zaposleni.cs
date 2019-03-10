using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan2
{
    class Zaposleni
    {
        string ime;
        string prezime;
        double koefRadnogMesta;
        double plata;

        public Zaposleni() { }

        public Zaposleni(string ime, string prezime, double koef)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.koefRadnogMesta = koef;
        }

        public void RacunajPlatu(int brojDana)
        {
            this.plata = koefRadnogMesta * brojDana * 100;
        }

        public void StampajPlatu()
        {
            // Console.WriteLine("Plata za {0} {1} iznosi {2:C2}", ime, prezime, plata);
            Console.WriteLine(ime + " " + prezime +
                ", na radnom mestu sa koeficijentom " +
                koefRadnogMesta + " ima platu od " + plata);
        }
    }
}
