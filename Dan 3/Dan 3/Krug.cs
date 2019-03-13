using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_3
{
    class Krug : Oblik
    {
        double poluprecnik;

        public Krug(string boja, string tip, int brojStrana, int poluprecnik) : base(boja, tip, brojStrana)
        {
            this.poluprecnik = poluprecnik;
            Povrsina = Math.PI * poluprecnik * poluprecnik; 
        }
    }
}
