﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas
{
	class Hero : Unit
    {
		public Hero (int x, int y, string name):base (x,y,name)
        {			
        }

        public void MoveRight()
        {
                x++;
        }
        
        public void MoveLeft()
        {            
                x--; 
        }

        public  void Render()
        {
            Console.SetCursorPosition(x,y);
            Console.Write("@");
        }
    }
}
