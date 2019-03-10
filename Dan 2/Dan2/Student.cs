using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan2
{
    class Student
    {
        string ime;                     // ime studenta
        string prezime;                 // prezime studenta
        double test1, test2, prosek;    // ocene na testovima
                                        // njihov prosek

        public Student(string i, string p, double t1, double t2)
        {
            ime = i;
            prezime = p;
            test1 = t1;
            test2 = t2;
        }
    }
}
