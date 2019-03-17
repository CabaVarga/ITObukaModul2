using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblici
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Foo();
            A b = new B();
            b.Foo();
            A c = new C();
            c.Foo();
            ((B)c).Foo();


        }

        class Oblik
        {

        }

        class A { public void Foo() { Console.WriteLine("AAA"); } }
        class B : A { public new void Foo() { Console.WriteLine("BBB"); } }
        class C : B { public void Foo() { Console.WriteLine("CCC"); } }

        class Osoba { }
        class Zena : Osoba { string devojackoPrezime; }
    }
}
