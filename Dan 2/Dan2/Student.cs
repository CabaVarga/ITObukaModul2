using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan2
{
    class Student
    {
        //string ime;                     // ime studenta
        //string prezime;                 // prezime studenta
        //double test1, test2, prosek;    // ocene na testovima
        //                                // njihov prosek
        private string ime;
        private string prezime;
        private double test1;
        private double test2;
        private double prosek;

        public Student(string i, string p, double t1, double t2)
        {
            ime = i;
            prezime = p;
            test1 = t1;
            test2 = t2;
        }

        // dodavanje pristupnih atributa
        // kod svih pojedinacnih atributa bismo morali definisati pravo pristupa

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }


        public double Test1
        {
            get { return test1; }
            set { test1 = value; }
        }


        public double Test2
        {
            get { return test2; }
            set { test2 = value; }
        }


        public double Prosek
        {
            get { return prosek; }
            set { prosek = value; }
        }

    }
}
