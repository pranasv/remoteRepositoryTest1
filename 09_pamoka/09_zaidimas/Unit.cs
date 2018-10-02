
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas
{
	class Unit
	{
		protected int x;
		protected int y;
		private string name;
		public Unit(int x, int y, string name)
		{
			this.x = x;
			this.y = y;
			this.name  = name;
		}
		 public void PrintInfo()
        {
            Console.WriteLine("Unit "+name+" X:"+x+" Y:"+y);
        }
	}
}
