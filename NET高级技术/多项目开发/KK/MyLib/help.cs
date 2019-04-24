using System;
namespace MyLib
{
    public class Help
    {
        public Help()
        { 
        }

        public static bool IsEmail(string s)
        {
            return s.Contains("@");
        }
    
    }
}
