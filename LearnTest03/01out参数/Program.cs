using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入用户名：");
            string username = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = Console.ReadLine();
            string msg;
            bool result = IsLogin(username, password, out msg);
            Console.WriteLine("登录状态：{0},\t登录信息：{1}",result, msg);
            Console.ReadKey();
        }
        /// <summary>
        /// 检测登录结果
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="msg">登录信息</param>
        /// <returns>登录结果</returns>
        public static bool IsLogin(string username, string password, out string msg)
        {
            if (username == "admin" && password == "123456")
            {
                msg = "登录成功！";
                return true;
            }
            else if (username == "admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (password == "123456")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "错误";
                return false;
            }
        }
    }
}
