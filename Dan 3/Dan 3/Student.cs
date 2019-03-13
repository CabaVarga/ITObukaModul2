using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Student : Osoba
    {
        int brojIndeksa;
        double test1;
        double test2;

        public Student(string ime, string prezime, int starost,
            int brojIndeksa, double test1, double test2) : base(ime, prezime, starost)
        {
            this.brojIndeksa = brojIndeksa;
            this.test1 = test1;
            this.test2 = test2;
        }

        public double RacunajPoene()
        {
            double prosek = (test1 + test2) / 2;
            return prosek;
        }

        public void StampajPoene()
        {
            Console.WriteLine("Student {0} {1} - prosecan broj poena: {2}",
            ime, prezime, RacunajPoene());
        }
    }
}
