using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Cat:Creature
    {
        public string status;

        public Cat(int l, string r, string h, int w,string s) : base(l, r, h, w)
        {
            this.status = s;
        }
    }
}
