using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    [Serializable()]
    abstract class ZicaniInstument : Instrument
    {
        public override string TipInstrumenta { get => "Zicani instrument"; }
        public override bool ImaZice { get => true; }
        public override bool ImaDugmice { get => false; }
        public override bool ImaUdaraljke { get => false; }
    }
}
