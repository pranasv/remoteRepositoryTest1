using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class GameWindow : Window
    {
        //private Button StartButton;
        // private Button CreditsButton;
        // private Button QuitButton;
        private List<Button> AllButtons = new List<Button>();
        private int CurrentSelection = 0;
        private TextBlock TitleTextBlock;
        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            TitleTextBlock = new TextBlock(2, 5, 114, 30, new List<String> { "Super duper zaidimas", "Prano Vaiciaus kuryba!", "Made in Vilnius Coding School!" });

            AllButtons.Add(new Button(20, 13, 18, 5, "Start"));
            AllButtons.Add(new Button(50, 13, 18, 5, "Credits"));
            AllButtons.Add(new Button(80, 13, 18, 5, "Quit"));

        }
        public void SellectNextMenuItem()
        {
            if (CurrentSelection < AllButtons.Count - 1)
            {
                CurrentSelection++;
                ActivateCurrentButtonSelection();
            }
        }

        public int GetCurrentSelection()
        {
            return CurrentSelection;
        }

        public void SellectPrevMenuItem()
        {
            if (CurrentSelection > 0)
            {
                CurrentSelection--;
                ActivateCurrentButtonSelection();
            }
        }

        private void ActivateCurrentButtonSelection()
        {
            for (int i = 0; i < AllButtons.Count; i++)
            {
                Button btn = AllButtons[i];
                if (i == CurrentSelection)
                {
                    btn.SetActive();
                }
                else
                {
                    btn.SetNotActive();
                }



            }
        }


        public new void Render()
        {
            base.Render();
            TitleTextBlock.Render();
            foreach (Button btn in AllButtons)
            {
                btn.Render();

            }
            Console.SetCursorPosition(0, 0);

        }


    }
}
