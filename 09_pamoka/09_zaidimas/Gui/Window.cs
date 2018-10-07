using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class Window : GuiObject
    {
        private Frame Border;
        public Window (int x, int y, int width, int height, char symbol):base (x,y,width,height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height=height;
            Border = new Frame(this.x,this.y,this.width,this.height,symbol);
        }        
        public void Render()
        {
            Border.Render();
        }
    }
}
