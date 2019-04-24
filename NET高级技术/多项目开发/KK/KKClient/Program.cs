using System;
using MyLib;

namespace KKClient
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "123@163.com";
            Console.WriteLine(Help.IsEmail(s));
        }
    }
}
