using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    class Program
    {
        static void Main(string[] args)
        {
            // novi studenti
            Student st1 = new Student();
            Student st2 = new Student();

            // unos podataka za prvog studenta
            st1.PostaviImePrezime("Marko", "Trkulja");
            st1.PostaviPoene(7.45, 8.23);
            st1.IzracunajProsek();

            // unos podataka za drugog studenta
            st2.PostaviImePrezime("Maja", "Milosevic");
            st2.PostaviPoene(9.23, 8.32);
            st2.IzracunajProsek();

            // ispis uspeha studenata
            st1.IspisiUspeh();
            st2.IspisiUspeh();

            Console.ReadKey();
        }
    }
}
