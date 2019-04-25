using System;
using System.Collections.Generic;

namespace Progress
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello world";
            char[] schar = s.ToCharArray();

            List<char> clist = new List<char>();

            foreach(char c in schar)
            {
                clist.Add(c);
            }

            var p1 = new Person(clist);

            Console.WriteLine(p1[0, 5]);

        }
    }

    class Person
    {
        private List<char> name { get; set; }

        public string this[int x, int y]
        {
            get
            {
                if (x < y) {
                    var temp = new char[y - x + 1];
                    for(int i=x; i<=y; i++)
                    {
                        temp[i - x] = name[i];
                    }
                    return new string(temp);
                }
                else
                {
                    return "";
                }
            }

        }

        public Person(List<char> name)
        {
            this.name = name;
        }

    }
}
