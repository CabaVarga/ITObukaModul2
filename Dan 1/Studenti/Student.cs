using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    class Student
    {
        public string ime;                  // ime studenta
        public string prezime;              // prezime studenta
        public double test1, test2, prosek; // ocene na testovima

        public Student()
        {

        }

        public Student(string i, string p)
        {
            ime = i;
            prezime = p;
        }

        public void PostaviImePrezime(string i, string p)
        {
            ime = i;
            prezime = p;
        }

        public void PostaviPoene(double t1, double t2)
        {
            test1 = t1;
            test2 = t2;
        }

        public double IzracunajProsek()
        {
            prosek = (test1 + test2) / 2;
            return prosek;
        }

        public string DobaviPunoIme()
        {
            string punoime = ime + " " + prezime;
            return punoime;
        }

        public void IspisiUspeh()
        {
            Console.WriteLine("Student {0} {1} ima uspeh : {2:F2}", ime, prezime, prosek);
        }
    }
}
