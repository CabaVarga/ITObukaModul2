using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    [Serializable()]
    public abstract class UdarackiInstrument : Instrument
    {
        public override string TipInstrumenta => "Udaracki instrument";
        public override bool ImaZice => false;
        public override bool ImaDugmice => false;
        public override bool ImaUdaraljke => false;
    }
}
