using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class TextLine : GuiObject
    {
        private string data;

        public TextLine (int x, int y, int width, string data):base(x,y,width,1)
        {
            this.data = data;
        }
        public void Render()
        {
            Console.SetCursorPosition(x, y);
            if (width > this.data.Length)
            {
                int offset = (width - this.data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            Console.Write(this.data);
        }
    }
}
