using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryObrazac
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IVozilo
    {
        void Vozi();
    }

    class Automobil : IVozilo
    {
        public void Vozi() { Console.WriteLine("Vozim automobil..."); }
    }

    class Kamion : IVozilo
    {
        public void Vozi() { Console.WriteLine("Vozim kamion..."); }

    }

    class Motocikl : IVozilo
    {
        public void Vozi() { Console.WriteLine("Vozim motocikl..."); }

    }

    class FabrikaVozila
    {
        public IVozilo PribaviVozilo(char tip)
        {
            switch (tip)
            {
                case 'a':
                    {
                        return new Automobil();
                    }
                case 'k':
                    {
                        return new Kamion();
                    }
                case 'm':
                    {
                        return new Motocikl();
                    }
                default:
                    return null;
            }
        }
    }

}
