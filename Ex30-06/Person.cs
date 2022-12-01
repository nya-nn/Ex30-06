using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_06
{
    class Person:Life
    {
        public string name;
        public int age;
        public int height;
        public int weight;
        public string birthDay;
        public Person(int l,string n,int a,int h, int w,string bd):base(l)
        {
            this.name = n;
            this.age = a;
            this.height = h;
            this.weight = w;
            this.birthDay = bd;
        }

        public string GetBD(string bd)
        {
            string celebrate;
            DateTime dt = DateTime.Now;

            string day =dt.ToString("MM/dd");

            if (bd == day)
            {
                celebrate = "今日は誕生日です";
            }
            else
            {
                celebrate = "今日は誕生日ではありません";
            }
            return celebrate;
        }
    }

}
