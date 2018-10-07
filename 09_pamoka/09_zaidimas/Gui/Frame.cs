using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class Frame : GuiObject
    {
        private char RenderChar;

        public Frame(int x, int y, int width, int height, char renderchar):base(x,y,width,height)
        {
            RenderChar = renderchar;
        }
        public void Render()
        {
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(this.x, this.y + i);
                if (i == 0 || i == this.height - 1)
                {
                    for (int j = 0; j < this.width; j++)
                    {
                        Console.Write(this.RenderChar);
                    }
                }
                else
                {
                    Console.Write(this.RenderChar);
                    for (int j = 0; j < this.width - 2; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(this.RenderChar);
                }
            }
        }
    }
}
