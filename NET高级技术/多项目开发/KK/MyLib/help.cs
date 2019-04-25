using System;
using System.Configuration;
namespace MyLib
{
    //一个类必须声明成 public才能被其他项目引用
    public class Help
    {
        public Help()
        { 
        }

        public static bool IsEmail(string s)
        {
            return s.Contains("@");
        }

        public static string Execute(string s)
        {

            return "888" + s;
        }

    }
}
