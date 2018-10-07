using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class GuiObject
    {
        protected int height;
        protected int width;
        protected int x;
        protected int y;

        public GuiObject(int x, int y,int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
