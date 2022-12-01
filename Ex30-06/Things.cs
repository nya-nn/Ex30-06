using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Things:Life
    {
        public int weight;
        public string manufacturer;

        public Things(int l,int w,string m) : base(l)
        {
            this.weight = w;
            this.manufacturer = m;
        }
    }
}
