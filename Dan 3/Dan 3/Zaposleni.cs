using System;

namespace Dan_3
{
    class Zaposleni : Osoba
    {
        double koefRadnogMesta;
        double plata;

        public Zaposleni(string ime, string prezime, int starost, double koefRadnogMesta) : base(ime, prezime, starost)
        {
            this.koefRadnogMesta = koefRadnogMesta;
        }

        public void RacunajPlatu(int brojDana)
        {
            this.plata = koefRadnogMesta * brojDana * 100;
        }

        public void StampajPlatu()
        {
            PredstaviSe();
            Console.WriteLine("Plata iznosi: {0:C2}", this.plata);   
        }
    }
}
