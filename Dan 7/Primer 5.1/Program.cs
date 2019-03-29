using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\ITBrains\";
            string in_file = "spisak.txt";
            string out_file = "uredjeniSpisak.txt";

            StreamReader sr = new StreamReader(path + in_file);
            List<Polaznik> polaznici = UcitajPolaznike(sr);

            var sortiranoPoImenu = from p in polaznici
                                   orderby p.Ime, p.Prezime, p.JMBG
                                   select p;

            foreach (var p in sortiranoPoImenu)
            {
                Console.WriteLine("{0} {1} {2}", p.Ime, p.Prezime, p.JMBG);
            }


            StampajPolaznike(polaznici);

            // SNIMANJE

            StreamWriter sw = new StreamWriter(path + out_file);
            SnimiPolaznike(sw, sortiranoPoImenu);
            sw.Close(); // OVO JE BITNO!
        }

        public static void StampajPolaznike(List<Polaznik> lp)
        {
            Console.WriteLine("--- POLAZNICI ---");
            foreach (var p in lp)
            {
                Console.WriteLine("{0},{1},{2}", p.Ime, p.Prezime, p.JMBG);
            }
        }

        public static List<Polaznik> UcitajPolaznike(StreamReader sr) {
            List<Polaznik> polaznici = new List<Polaznik>();
            try
            {
                while (sr.Peek() >= 0)
                {
                    string[] data = sr.ReadLine().Split(',');
                    Polaznik p = new Polaznik();
                    p.Ime = data[0];
                    p.Prezime = data[1];
                    p.JMBG = data[2];
                    polaznici.Add(p);
                }
            }
            catch (FileNotFoundException e) { } 
            finally
            {
                sr.Close();
            }

            return polaznici;
        }

        public static void SnimiPolaznike(StreamWriter sw, IEnumerable<Polaznik> lp)
        {
            foreach (var p in lp)
            {
                sw.Write(p.Ime);
                sw.Write(",");
                sw.Write(p.Prezime);
                sw.Write(",");
                sw.Write(p.JMBG);
                sw.WriteLine();
            }
        }
    }

    public class Polaznik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
    }
}
