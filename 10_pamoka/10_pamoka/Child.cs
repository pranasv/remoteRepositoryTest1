using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_pamoka
{
    class Child:Parent
    {
        public override void VirtualFunction()
        {
            base.VirtualFunction();
            Console.WriteLine("Child Virtual overriden");
        }
        public new void HiddenFunction()
        {
            Console.WriteLine("Child new Hidden");
        }
    }
}
