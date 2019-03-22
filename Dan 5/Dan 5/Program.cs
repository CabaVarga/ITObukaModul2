using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_5
{
    class Program
    {
        static void Main(string[] args)
        {
            A ovojeA = new A();
            A ovojeBkaoA = new B();
            B ovojeB = new B();

            ovojeA.M();
            ovojeBkaoA.M();
            ovojeB.M();

            Test nt = new Test();
            nt.Prinit();
        }
    }

    public class A
    {
        public void M()
        {
            Console.WriteLine("Ovo pise A");
        }
    }

    public class B : A
    {
        public void M()
        {
            Console.WriteLine("Ovo pise B");
        }
    }

    public abstract class C
    {
        //public string Name { get; set; }

        //public abstract void PrintName();

        public void Ispis()
        {
            Console.WriteLine("Moze??");
        }
    }

    public class M : IIme { public virtual void Hello() { } public void Ime() { } }
    public class N : M { }
    public class O : N { public override void Hello() { } }

    public interface IIme
    {
        void Ime();
    }

    public class Test
    {
        public void Prinit()
        {
            IIme mojN = new N();
            var mojM = (M)mojN;
            Console.ReadKey();
        }
    }
}
