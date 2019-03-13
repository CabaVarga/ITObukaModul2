using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Kvadrat : Oblik
    {
        double duzinaStranice;

        public Kvadrat(string boja, string tip, int brojStrana, double duzinaStranice) : base(boja, tip, brojStrana)
        {
            this.duzinaStranice = duzinaStranice;
            Povrsina = duzinaStranice * duzinaStranice; 
        }
}
}
