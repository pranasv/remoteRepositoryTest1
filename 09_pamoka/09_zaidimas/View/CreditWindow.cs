using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.GUI
{
    class CreditWindow : Window
    {
        private Button BackButton;

        private TextBlock CreditTextBlock;

        public CreditWindow() : base(28, 10, 60, 18, '@')
        {
            List<String> creditData = new List<string>();

            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Programuotojas:");
            creditData.Add("Pranas Vaicius");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");
            creditData.Add("Marketingas:");
            creditData.Add("Vardas Vardaitis");
            creditData.Add("");

            CreditTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, 1 ,creditData);


            BackButton = new Button(28 + 20, 10 + 14, 18, 3, "Back");
            BackButton.SetActive();

            Render();
        }

        public new void Render()
        {
            base.Render();
            CreditTextBlock.Render();
            BackButton.Render();

            Console.SetCursorPosition(0, 0);
        }

    }
}

