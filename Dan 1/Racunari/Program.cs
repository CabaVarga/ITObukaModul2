/* Zadatak broj 3 iz slajda
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunari
{
    class Program
    {
        static void Main(string[] args)
        {
            Racunar r1 = new Racunar();
            Racunar r2 = new Racunar();
            Racunar r3 = new Racunar();
            Racunar r4 = new Racunar();
            Racunar r5 = new Racunar();

            Racunar[] racunari = new Racunar[5];

            r1.PostaviNazivRadniTakt("Pentium C12", 3454);
            r1.PostaviKapacitet(1);
            r2.PostaviNazivRadniTakt("Silicijum Ax", 4500);
            r2.PostaviKapacitet(2);
            r3.PostaviNazivRadniTakt("Komodor Giga32", 3245);
            r3.PostaviKapacitet(3);
            r4.PostaviNazivRadniTakt("Spektrum Omega", 9800);
            r4.PostaviKapacitet(6);
            r5.PostaviNazivRadniTakt("EINIS Prodor 2", 7555);
            r5.PostaviKapacitet(4);

            racunari[0] = r1;
            racunari[1] = r2;
            racunari[2] = r3;
            racunari[3] = r4;
            racunari[4] = r5;

            Console.WriteLine("--- Pre sortiranja -----\n");
            IspisiRacunare(racunari);

            // LINQ je bogom dan za ovo!
            var poPerformansama =
                from racunar in racunari
                orderby racunar.IzracunajIndeksPerformansi()
                select racunar;

            // SortirajPoPerformansama(racunari);
            Console.WriteLine("\n--- Nakon sortiranja ---\n");
            foreach (var r in poPerformansama)
            {
                r.StampajIndeksPerformansi();
            }

            // IspisiRacunare(racunari);
        }

        public static void SortirajPoPerformansama(Racunar[] masine)
        {
            for (int i = 0; i < masine.Length; i++)
            {
                int min = i;
                for (int j = i; j < masine.Length; j++)
                {
                    if (masine[j].IzracunajIndeksPerformansi() < masine[min].IzracunajIndeksPerformansi())
                    {
                        min = j;
                    }
                }
                Racunar temp = masine[i];
                masine[i] = masine[min];
                masine[min] = temp;
            }
        }

        public static void IspisiRacunare(Racunar[] masine)
        {
            foreach (Racunar r in masine)
            {
                r.StampajIndeksPerformansi();
            }
        }
    }
}
