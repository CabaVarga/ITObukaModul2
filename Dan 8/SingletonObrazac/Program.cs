using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonObrazac
{
    class Program
    {
        static void Main(string[] args)
        {
            Popokatepetl sin = Popokatepetl.Grotlo;
            Popokatepetl son = Popokatepetl.Grotlo;
        }
    }

    public sealed class Popokatepetl
    {
        private static Popokatepetl grotlo;

        private Popokatepetl() { Console.WriteLine("Singleton kreiran"); }

        public static Popokatepetl Grotlo
        {
            get
            {
                if (grotlo == null)
                {
                    grotlo = new Popokatepetl();
                }
                return grotlo;
            }
        }
    }

    public sealed class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
