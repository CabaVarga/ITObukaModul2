using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_5._2
{
//     public delegate double Operacije(int a, int b);
    public delegate void IzvrsilacOperacija(int n);

    public delegate int Maska();

    class Program
    {
        static private int rezultat;

        static void Main(string[] args)
        {
            rezultat = 0;
            //Operacije ops = (a, b) => a + b;
            //Console.WriteLine(ops(5, 6));
            IzvrsilacOperacija digitron = new IzvrsilacOperacija(Sabiranje);
            digitron.Invoke(1);
            Console.WriteLine(rezultat);
            digitron.Invoke(2);
            Console.WriteLine(rezultat);
            digitron.Invoke(3);
            Console.WriteLine(rezultat);

            Console.WriteLine("--- Dodajemo drugu operaciju ---");

            digitron += new IzvrsilacOperacija(Mnozenje);
            digitron.Invoke(1);
            Console.WriteLine(rezultat);
            digitron.Invoke(2);
            Console.WriteLine(rezultat);

            Console.WriteLine("--- Dodajemo jos jednu operaciju, ponovo mnozenje ---");
            digitron += new IzvrsilacOperacija(Mnozenje);
            digitron.Invoke(3);
            Console.WriteLine(rezultat);

            digitron -= new IzvrsilacOperacija(Mnozenje);
            digitron -= new IzvrsilacOperacija(Mnozenje);

            Console.WriteLine("--- Skinuli smo oba mnozenja ---");

            digitron.Invoke(3);
            Console.WriteLine(rezultat);
            digitron.Invoke(3);
            Console.WriteLine(rezultat);

            Console.ReadKey();
        }

        private static void Mnozenje(int n)
        {
            rezultat *= n;
        }

        private static void Sabiranje(int n)
        {
            rezultat += n;
        }
    }
}
