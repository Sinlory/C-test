using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 23, 45, 44 };
            //Test(23, 45, 67);//可接逗号分隔的指定类型的数值
            //Test();//可什么都不接
            Test(nums);//可接指定类型的数组
        }

        public static void Test(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
