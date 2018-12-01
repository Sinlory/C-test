using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04属性
{
    public class Person
    {
        private int _age;
        public int Age
        {
            set { _age = value; }
            get { return _age; }
            //可以在{}中增加限定条件
        }

        public static void Main(string[] args)
        {

        }
    }

}
