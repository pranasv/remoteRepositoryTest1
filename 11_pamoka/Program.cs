using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSetClass a = new GetSetClass();
            Console.WriteLine(a.text1);
            Console.WriteLine(a.text2);
            //Console.WriteLine(a.text3);
            Console.WriteLine(a.text4);
            a.text1 = "pakeistas string1";
            //a.text2 = "pakeistas string2";
            a.text3 = "pakeistas string3";
            //a.text4 = "pakeistas string4";
            Console.WriteLine(a.text1);
            Console.WriteLine(a.text2);
            //Console.WriteLine(a.text3);
            Console.WriteLine(a.text4);
            Console.ReadKey();
        }
    }
}
