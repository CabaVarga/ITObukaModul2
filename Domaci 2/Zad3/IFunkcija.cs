using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    interface IFunkcija
    {
        void UcitajParametre(string putanja);
        double VrednostFunkcije(double x);
        bool RealneNule();
        double[] NuleFunkcije();
    }
}
