using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyễn_Việt_Anh_0265867
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Nam" , "Tan" , "Nien" , "Linh" , " Hoang"};
            int[] height = { 170, 180, 160, 175, 165 };
            int[] weight = { 70, 80, 60, 75, 65 };
            bool[] gender = { true, true, true , false, true };

            Person.person1 = new Person( "Tien", 170, 70, true );
            Console.WriteLine( Person.person1.Name + "\t" + Person.person1.height + "\t" + Person.person1.weight + "\t" + Person.person1.isMale );
            Console.WriteLine;
        }
    }
}
