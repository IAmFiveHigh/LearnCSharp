using System;
using MyLib;

namespace KKServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "bb@qq.com";
            Console.WriteLine(Help.IsEmail(s));
        }
    }
}
