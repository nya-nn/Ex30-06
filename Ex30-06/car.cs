using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class car:Things
    {
        public string color;

        public car(int l, int w, string m,string c) : base(l, w, m)
        {
            this.color = c;
        }
    }
}
