using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyễn_Việt_Anh_0265867
{
    internal class Person
    {
        public string Name;
        public int height;
        public int weight;
        public bool isMale;
        public Person(string name, int height, int weight, bool isMale)
        {
            Name = name;
            this.height = height;
            this.weight = weight;
            this.isMale = isMale;
        }
    }
}
