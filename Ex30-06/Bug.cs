using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Bug:Creature
    {
        public string wing;

        public Bug(int l, string r, string h, int w,string wing) : base(l, r, h, w)
        {
            this.wing = wing;
        }
    }
}
