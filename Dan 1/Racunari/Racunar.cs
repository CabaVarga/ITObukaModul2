using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunari
{
    class Racunar
    {
        string procesor;
        double radniTakt;
        int kapacitetMemorije;

        public void PostaviNazivRadniTakt(string naziv, double takt)
        {
            procesor = naziv;
            radniTakt = takt;
        }

        public void PostaviKapacitet(int gb)
        {
            kapacitetMemorije = gb;
        }

        public double IzracunajIndeksPerformansi()
        {
            double indeksPerformansi = 10 * radniTakt + kapacitetMemorije;
            return indeksPerformansi;
        }

        public void StampajIndeksPerformansi()
        {
            Console.WriteLine("{0} : {1}", procesor, IzracunajIndeksPerformansi());
        }
    }
}
