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
            Console.WriteLine("skaicius 1:");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("skaicius 2:");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("skaicius 3:");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Didziausias skaicius yra "+max(sk1, sk2, sk3));
            Console.ReadKey();
        }
        static int max(int sk1, int sk2, int sk3)
        {
            if (sk1 > sk2 && sk1 > sk3)
            {
                return sk1;
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                return sk2;
            }
            else
            {
                return sk3;
            }
        }
    }
}
