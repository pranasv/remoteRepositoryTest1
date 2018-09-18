using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteRepoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 1 skaiciu:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite 2 skaicius:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite 3 skaiciu:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("didziausias is ju yra: "+Max(a,b,c));            
            Console.WriteLine("press any key...");
            Console.ReadKey();
        }
        static int Max (int a,int b, int c)
        {
            if (a>b && a>c)
            {
                return a;
            }
            else if (b>a && b>c)
            {
                return b;
            }
            else
            {
                return c;
            }


        }
    }
}
