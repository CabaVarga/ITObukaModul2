using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoziloMotor
{
    public class Kamion : Vozilo
    {
        private int brojOsovina;

        public Kamion(String marka, String tip,
        String registracija,
        int godiste, Osoba vlasnik, int brojOsovina) :
        base(marka, tip, registracija, godiste, vlasnik)
        {
            this.brojOsovina = brojOsovina;
        }

        public int PribaviBrojOsovina() { return this.brojOsovina; }

        public void stampajPodatke()
        {
            Console.WriteLine(PribaviMarku() + " " +
            PribaviTip() + " " +
            PribaviGodiste() + " " +
            PribaviRegistraciju() + " " +
            PribaviBrojOsovina() + " " +
            vlasnik.PribaviIme() + " " +
            vlasnik.PribaviPrezime());
        }
    }
}
