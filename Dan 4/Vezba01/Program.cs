using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vezba01.Forms;

namespace Vezba01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Institucija> institucije = PopuniListe();
            Form1 myform = new Vezba01.Forms.Form1();
            // myform.Show();
            // myform.Activate();


            AppData.Institucije = PopuniListe();
            

            
            Application.Run(myform);

            Console.ReadKey();

        }

        static void Test1()
        {

        }

        static List<Institucija> PopuniListe()
        {
            List<Institucija> li = new List<Institucija>();
            li.Add(new Institucija("Narodni univerzitet", "Marsala Tita 234"));
            li.Add(new Institucija("VoICT Akademija", "Zeleznicka 32"));
            li.Add(new Institucija("FTN", "Uciteljska 45 a"));


            // nekoliko zaposlenih
            Zaposleni z1 = new Nastavnik("Milos", "Milosevic", "2339", "prof.dr", 30);
            Zaposleni z2 = new Asistent("Dragan", "Djuric", "323423", z1 as Nastavnik, 3);

            li[1].DodajZaposlenog(z1);
            li[1].DodajZaposlenog(z2);

            return li;
        }
    }
}
