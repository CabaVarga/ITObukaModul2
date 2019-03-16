using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoziloMotor

{
    public class Vozilo
    {
        protected String marka;
        protected String tip;
        protected String registracija;
        protected int godiste;

        public Motor pogonskiAgregat;

        protected Osoba vlasnik;
        protected Vozilo(String marka, String tip, String registracija, int godiste, Osoba vlasnik)
        {
            this.marka = marka;
            this.tip = tip;
            this.registracija = registracija;
            this.godiste = godiste;
            this.vlasnik = vlasnik;
        }

        protected void PrenosVlasnistva(Osoba noviVlasnik)
        {
            this.vlasnik = noviVlasnik;
        }

        public string PribaviMarku() { return this.marka; }
        public string PribaviTip() { return this.tip; }
        public int PribaviGodiste() { return this.godiste; }
        public string PribaviRegistraciju() { return this.registracija; }
        
        protected void StampajPodatke()
        {
            Console.WriteLine(PribaviMarku() + " " +
            PribaviTip() + " " +
            PribaviGodiste() + " " +
            PribaviRegistraciju() + " " +
            vlasnik.PribaviIme() + " " +
            vlasnik.PribaviPrezime());
        }
    }
}
