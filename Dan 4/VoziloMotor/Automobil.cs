using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoziloMotor
{
    public class Automobil : Vozilo
    {
        private int brojVrata;
        public Automobil(String marka, String tip,
        String registracija, int godiste,
        Osoba vlasnik, int brojVrata) :
        base(marka, tip, registracija, godiste, vlasnik)
        {
            this.brojVrata = brojVrata;
        }

        public int PribaviBrojVrata() { return this.brojVrata; }

        public void StampajPodatke()
        {
            Console.WriteLine(PribaviMarku() + " " +
            PribaviTip() + " " +
            PribaviGodiste() + " " +
            PribaviRegistraciju() + " " +
            PribaviBrojVrata() + " " +
            vlasnik.PribaviIme() + " " +
            vlasnik.PribaviPrezime());
        }
    }
}
