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

            //exercise1();
            //exercise2();
            // uzduotis_nr3();
            uzduotis_nr4();



        }
        static void exercise1()
        {
            Console.WriteLine("iveskite 1 skaiciu:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite 2 skaicius:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite 3 skaiciu:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("didziausias is ju yra: " + Max(a, b, c));
            Console.WriteLine("press any key...");
            Console.ReadKey();
        }
        static void exercise2()
        {
            Console.WriteLine("iveskite 1 skaiciu:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite 2 skaicius:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite 3 skaiciu:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (InRange(a,b,c))
            {
                Console.WriteLine("pirmas skaicius yra rezyje tarp sekanciu dvieju");
            }
            else
            {
                Console.WriteLine("pirmas skaicius nera rezyje tarp sekanciu dvieju");
            }
            Console.WriteLine("didziausias is ju yra: " + Max(a, b, c));
            Console.WriteLine("press any key...");
            Console.ReadKey();
        }
        static int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static bool InRange(int testnum, int min, int max)
        {
            if (testnum>min && testnum<max)
            {
                return true;
            }
            else
            {
                return false;
            }

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
        static void uzduotis_nr3()
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
        static void uzduotis_nr4()
        {
            Console.WriteLine("random 1..20: "  );
            Console.ReadKey();
        }
        static void D20()
        {
           // return random(20);
        }
        

    }
}
