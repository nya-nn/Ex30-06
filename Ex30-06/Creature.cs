using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Creature:Life
    {
        public string race;
        public string habitat;
        public int weight;
        
        public Creature(int l,string r,string h,int w) : base(l)
        {
            this.race = r;
            this.habitat = h;
            this.weight = w;
        }
    }
}
