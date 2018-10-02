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
            Console.WriteLine();
            BankAccount saskaita1 = new BankAccount(0001,"Pranas");    
            
            /*foreach (string item in saskaita1.GetHistory)
            {
            	Console.WriteLine(item);
            }*/
            saskaita1.PrintHistory();            
            saskaita1.AddMoney(100);
            saskaita1.PrintHistory();
            saskaita1.GetMoney(-30);            
            Console.WriteLine("Saskaitos balansas: " + saskaita1.GetBalance); ///???
            Console.ReadKey();
            
        }
    }
}
