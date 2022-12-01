using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class clothes:Things
    {
        public string season;

        public clothes(int l, int w, string m, string s) : base(l, w, m)
        {
            this.season = s;
        }
    }
}
