using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas
{
    class Game
    {
        public void StartGame()       
        {
            GameScreen MyGame = new GameScreen(100, 30);
            Hero Player = new Hero(50, 30, "Player1");
            MyGame.SetHero(Player);
            Random RND = new Random();
            for (int i = 0; i < 10; i++)
            {
                MyGame.AddEnemy(new Enemy(i, RND.Next(0, 100), RND.Next(0, 30), "Enemy" + (i + 1)));
            }
            MyGame.Render();
            bool needToRender = true;
            do
            {
                Console.Clear();                
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo PressedChar = Console.ReadKey(true);
                    switch (PressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            Player.MoveRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            Player.MoveLeft();
                            break;
                    }
                }
                MyGame.MoveAllEnemiesDown();
                MyGame.Render();
                System.Threading.Thread.Sleep(250);
            }
            while (needToRender);
        }
    }
}
