using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Viola : ZicaniInstument, IFunkcijaUOrkestru
    {
        public Viola()
        {
            if (Program.illustrateFlag)
            {
                Console.WriteLine("Viola kreirana");
            }
        }

        public override string ImeInstrumenta => "Viola";
        public override bool OsnovaOdMetala => false;
        public override bool OsnovaOdPlastike => false;
        public override bool OsnovaOdDrveta => true;

        // Implementacija interfejsa IFunkcijaUOrkestru
        public string MojaFunkcijaUOrkestru { get; set; }
        public bool NeophodanSamZaSimfonijskiOrkestar => true;
        public string PripadamOrkestruPoImenu { get; set; }

        // Ispis osobina
        public override void Ispisi()
        {
            base.Ispisi();
            Console.WriteLine(
                "Moja funkcija u orkestru: " + MojaFunkcijaUOrkestru + "\n" +
                "Neophodan sam za simfonijski orkestar: " +
                ((NeophodanSamZaSimfonijskiOrkestar) ? "DA" : "NE") + "\n" +
                "Pripadam orkestru po imenu: " + PripadamOrkestruPoImenu);
        }

        public override void NastimujSe()
        {
            Console.WriteLine("{0} se stimuje...", ImeInstrumenta);
        }

        public override void Sviraj()
        {
            Console.WriteLine("{0} svira...", ImeInstrumenta);
        }
    }
}
