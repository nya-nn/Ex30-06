using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Worker:Person
    {
        public int income;

        public Worker(int l, string n, int a, int h, int w,string bd,int i) : base(l, n, a, h, w,bd)
        {
            this.income = i;
        }
    }
}
