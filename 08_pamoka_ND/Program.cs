using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_pamoka_ND
{
    class Program
    {
        static void Main(string[] args)
        {
            PointInTime laikas = new PointInTime();
            Console.WriteLine(laikas.CurrentTime());
            Product preke = new Product("Duona");
            preke.SetPrice(1.2);
            preke.SetDimm(300, 100, 80);
            preke.SetWeight(0.9);
            preke.PrintAllInfo();
            
           
            Console.ReadKey();
        }
    }
}
