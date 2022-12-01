using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Fish:Creature
    {
        public string body;

        public Fish(int l, string r, string h, int w,string b) : base(l, r, h, w)
        {
            this.body = b;
        }
    }
}
