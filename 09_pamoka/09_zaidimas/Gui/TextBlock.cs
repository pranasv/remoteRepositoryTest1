﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class TextBlock : GuiObject
    {
        private List<TextLine> textBlocks = new List<TextLine>();

        public TextBlock (int x, int y, int width, int height, List<string> textList):base(x,y,width,height)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textBlocks.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }
        public void Render()
        {
            for (int i = 0; i < textBlocks.Count; i++)
            {
                textBlocks[i].Render();
            }
        }
    }
}
