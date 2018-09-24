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
            Console.WriteLine("iveskite skaiciu:");
            int sk = Convert.ToInt32(Console.ReadLine());
            if (IsPrimal(sk))
            {
                Console.WriteLine("skaicius yra pirminis");
            }
            else
            {
                Console.WriteLine("skaicius nera pirminis");
            }
            Console.ReadKey();
        }
        static bool IsPrimal(int sk)
        {
                for (int i = 2; i<sk; i++)
                {
                    if (sk % i == 0)
                    {
                    return false;
                    }
                }                          
            return true;
            

        }
    }
}
