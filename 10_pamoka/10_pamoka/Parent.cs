using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_pamoka
{
    class Parent
    {
        public virtual void VirtualFunction()
        {
            Console.WriteLine("Parent Virtual");            
        }
        public void HiddenFunction()
        {
            Console.WriteLine("Parent hidden function");
        }
        
        
    }
}
