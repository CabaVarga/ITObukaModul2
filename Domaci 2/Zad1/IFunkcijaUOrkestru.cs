using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    interface IFunkcijaUOrkestru
    {
        string MojaFunkcijaUOrkestru { get; set; }
        bool NeophodanSamZaSimfonijskiOrkestar { get; }
        string PripadamOrkestruPoImenu { get; set; }
    }
}
