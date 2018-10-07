using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class Button : GuiObject
    {
        private Frame ActiveFrame;
        private bool IsActive = false;
        private Frame NotActiveFrame;
        private TextLine TextLine;

        public Button (int x, int y, int width, int height, string label):base(x,y,width,height)
        {
            NotActiveFrame = new Frame(x, y, width, height, '+');
            ActiveFrame = new Frame(x, y, width, height, '#');
            TextLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, label);
        }
    
        public void Render()
        {
            if (IsActive)
            {
                ActiveFrame.Render();
            }
            else
            {
                NotActiveFrame.Render();
            }
            TextLine.Render();
        }
        public void SetActive()
        {
            IsActive = true;
        }
        public void SetNotActive()
        {
            IsActive = false;
        }
    }
}
