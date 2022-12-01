using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class refrigerator:Things
    {
        public int capacity;

        public refrigerator(int l, int w, string m,int c) : base(l, w, m)
        {
            this.capacity = c;
        }
    }
}
