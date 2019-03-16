using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoziloMotor
{
    public class Motocikl : Vozilo
    {
        private bool registrovan;
        public Motocikl(String marka, String tip,
        String registracija, int godiste,
        Osoba vlasnik, bool registrovan) :
        base(marka, tip, registracija, godiste, vlasnik)
        {
            this.registrovan = registrovan;
        }

        public bool PribaviRegistrovan() { return this.registrovan; }

        public void stampajPodatke()
        {
            base.StampajPodatke();
            string registrovan = PribaviRegistrovan() ?
            "Registrovan" : "Neregistrovan";
            Console.WriteLine(" " + registrovan);
        }
    }
}
