using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Student:Person
    {
        public int id;

        public Student(int l, string n, int a, int h, int w,string bd,int i) : base(l, n, a, h, w,bd)
        {
            this.id = i;
        }
    }
}
