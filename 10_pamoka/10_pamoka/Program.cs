using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            Child a = new Child();
            a.VirtualFunction();          
            a.HiddenFunction();
            Parent b = new Parent();            
            b.HiddenFunction();
            Console.ReadKey();
            Parent c = new Child();
            c.HiddenFunction();
           
        }
        
    }
}
