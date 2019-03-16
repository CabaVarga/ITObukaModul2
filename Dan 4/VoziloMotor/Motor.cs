using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoziloMotor
{
    public class Motor
    {
        private bool radi;      //pokrenut ili ne
        private string tip;     //dizel ili benzin
        private int snaga;      //snaga u kW
        private int kubikaza;   //kubikaza u ccm

        public Motor(bool radi, string tip, int snaga, int kubikaza)
        {
            this.radi = radi;
            this.tip = tip;
            this.snaga = snaga;
            this.kubikaza = kubikaza;
        }

        public void PostaviRadi(bool radi)
        {
            this.radi = radi;
        }

        public bool PribaviRadi()
        {
            return radi;
        }

        public void Ukljuci()
        {
            PostaviRadi(true);
        }

        public void Iskljuci()
        {
            PostaviRadi(false);
        }

        public string PribaviTip() { return this.tip; }
        public int PribaviSnagu() { return this.snaga; }
        public int PribaviKubikazu() { return this.kubikaza; }

        public void StampajPodatke()
        {
            Console.WriteLine("Informacije o motoru:");
            Console.WriteLine(
            "Ukljucen:" + PribaviRadi() +
            " Tip: " + PribaviTip() +
            " Snaga: " + PribaviSnagu() +
            " Kubikaza: " + PribaviKubikazu()
            );
        }
    }
}
