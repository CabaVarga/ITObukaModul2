using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    [Serializable()]
    public abstract class DuvackiInstrument : Instrument
    {
        public override string TipInstrumenta => "Duvacki instrument";
        public override bool ImaZice => false;
        public override bool ImaDugmice => true;
        public override bool ImaUdaraljke => false;
    }
}
