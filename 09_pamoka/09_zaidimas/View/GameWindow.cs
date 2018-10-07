using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class GameWindow:Window
    {
        private Button StartButton;
        private Button CreditsButton;
        private Button QuitButton;
        private TextBlock TitleTextBlock;
        public GameWindow ():base(0, 0, 120, 30, '%')
        {
            TitleTextBlock = new TextBlock(2, 5, 114, 30, new List<String> { "Super duper zaidimas", "Prano Vaiciaus kuryba!", "Made in Vilnius Coding School!" });

            StartButton = new Button(20, 13, 18, 5, "Start");
            StartButton.SetActive();
            CreditsButton = new Button(50, 13, 18, 5, "Credits");
            QuitButton = new Button(80, 13, 18, 5, "Quit");
            base.Render();
        }
        public new void Render()
        {
            base.Render();
            TitleTextBlock.Render();
            StartButton.Render();
            CreditsButton.Render();
            QuitButton.Render();
            Console.SetCursorPosition(0, 0);
        }


    }
}
